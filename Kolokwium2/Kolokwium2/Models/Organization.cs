using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8_DK.Models
{
    public class Organization
    {

        [Key]
        public int OrganizationId{ get; set; }
        [Required]
        [MaxLength(100)]
        public string OrganizationName { get; set; }
        [Required]
        [MaxLength(50)]
        public string organizationDomain { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Member> TMembers { get; set; }
        //prescrition
        // [Required]
        // public DateTime Date { get; set; }
        // [Required]
        // public DateTime DueDate { get; set; }

        // public int IdPatient { get; set; }
        // public int IdDoctor { get; set; }
        // [ForeignKey("IdPatient")]
        // public virtual Member Patient { get; set; }
        // [ForeignKey("IdDoctor")]
        // public virtual File Doctor { get; set; }
        // public virtual ICollection<Membership> Prescription_Medicaments { get; set; }



    }
}
