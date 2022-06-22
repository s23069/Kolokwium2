using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace APBD8_DK.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public IEnumerable<object> Doctor { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prescription_Medicament>(zwc =>
            {
                zwc.HasKey(e => new { e.IdMedicament, e.IdPrescription });
            });

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>().


        HasData(
                    new Patient { IdPatient = 1, FirstName = "Jan", LastName = "Kowalski", BirthDate = DateTime.Parse("2000-01-01") },
                    new Patient { IdPatient = 2, FirstName = "Jan", LastName = "Kowalski", BirthDate = DateTime.Parse("2000-01-01") }
                );


            modelBuilder.Entity<Doctor>().HasData(
                    new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jankowalski@gmail.com" },
                    new Doctor { IdDoctor = 2, FirstName = "Jan", LastName = "Kowalski", Email = "jankowalski@gmail.com" }
                );


            modelBuilder.Entity<Prescription>().HasData(
                new Prescription { IdPrescription = 1, Date= DateTime.Parse("2000-01-01"), DueDate= DateTime.Parse("2001-01-01"),IdPatient=1,IdDoctor=1 },
                new Prescription { IdPrescription = 2, Date= DateTime.Parse("2002-01-01"), DueDate= DateTime.Parse("2011-01-01"),IdPatient=2,IdDoctor=2 });

            modelBuilder.Entity<Prescription_Medicament>().HasData(
               new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 23, Details = "lalalallala" },
               new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 10, Details = "lalalallalaterazspiewajznami" });
            modelBuilder.Entity<Medicament>().HasData(
                new Medicament { IdMedicament = 1, Name = "lek1", Description = "duzobierz", Type = "silne" },
                new Medicament { IdMedicament = 2, Name = "lek22", Description = "maloobierz", Type = "slabe" });

        } 
    }
}

        //protected  override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
        //protected override void OnModelCreating (ModelBuilder modelBuilder)
        //{

    