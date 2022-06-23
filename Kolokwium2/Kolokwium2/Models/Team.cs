﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8_DK.Models
{
    public class Team
    {
        [Key]
        public int? TeamId { get; set; }
        public int OrganizationId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }
        [MaxLength(500)]
        public string TeamDescription { get; set; }

        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
        // [ForeignKey("IdDoctor")]
        // public virtual File Doctor { get; set; }
        // public virtual ICollection<Organization> Organizations { get; set; }
    }
}
