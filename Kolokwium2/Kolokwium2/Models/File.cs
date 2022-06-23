using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8_DK.Models
{
    public class File
    {
        [Key]
        public int FileId { get; set; }
      
        public int TeamId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FileName { get; set; }
        [Required]
        [MaxLength(4)]
        public string FileExtension { get; set; }
        [Required]
        public int FileSize { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }


        // public virtual ICollection<Prescription> Prescriptions { get; set; }
        //public class Patient
        //{
        //    [Key]
        //    public int IdPatient { get; set; }
        //    [Required]
        //    [MaxLength(100)]
        //    public string FirstName { get; set; }
        //    [Required]
        //    [MaxLength(100)]
        //    public string LastName { get; set; }
        //    [Required]
        //    public DateTime BirthDate { get; set; }
        //    public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
