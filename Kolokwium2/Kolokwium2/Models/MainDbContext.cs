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
        public DbSet<Member> Members { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        //public IEnumerable<object> Doctor { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Membership>(zwc =>
            {
                zwc.HasKey(e => new { e.MemberId });//, e.TeamId
            });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<File>(zwc =>
            {
                zwc.HasKey(e => new { e.TeamId });
            });

            //SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Member>().


        HasData(
                    new Member { MemberId = 1, OrganizationId = 1, MemberName = "jan", MemberSurname = "kow", MemberNickName = "12ss" },
                    new Member { MemberId = 2, OrganizationId = 2, MemberName = "janek", MemberSurname = "kowalczyk", MemberNickName = "12ten" }


                );


            modelBuilder.Entity<File>().HasData(
                    new File { FileId = 1, TeamId = 1, FileName = "tets", FileExtension = "var", FileSize = 12 },
                    new File { FileId = 2, TeamId = 2, FileName = "testy", FileExtension = "doc", FileSize = 120 }

                );
            modelBuilder.Entity<Team>().HasData(
                   new Team { TeamId = 1, OrganizationId = 1, TeamName = "testy", TeamDescription = "duzadruzyna" },
                   new Team { TeamId = 2, OrganizationId = 2, TeamName = "testy2", TeamDescription = "duzadruzyna2" }



               );
            modelBuilder.Entity<Organization>().HasData(
                   new Organization { OrganizationId = 1, OrganizationName = "iaseste", organizationDomain = "www.223.pl" },
                   new Organization { OrganizationId = 2, OrganizationName = "iaseste222", organizationDomain = "www.error3.pl" }




               );


            modelBuilder.Entity<Membership>().HasData(
                   new Membership { MemberId = 1, MembershipDate = DateTime.Parse("2000-01-01") },
                   new Membership { MemberId = 2, MembershipDate = DateTime.Parse("2002-02-11") }


               );





        }
    }
}


        //protected  override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
        //protected override void OnModelCreating (ModelBuilder modelBuilder)
        //{

    