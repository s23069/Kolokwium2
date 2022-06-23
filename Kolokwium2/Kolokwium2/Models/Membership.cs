using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD8_DK.Models
{
 
    public class Membership
    {
        
       
        public DateTime MembershipDate { get; set; }

        [ForeignKey("MemberId")]
        public virtual Member Member{ get; set; }
        public int? MemberId { get; set; }

        //[ForeignKey("TeamId")]
        //public virtual Team Team { get; set; }
        //public int? TeamId { get; set; }


        //public virtual Prescription Prescription { get; set; }

        //public int IdMedicament { get; set; }
        //public int IdPrescription { get; set; }
        //public int Dose { get; set; }
        //public string Details { get; set; }

        //[ForeignKey ("IdMedicament")]
        //public virtual Team Medicament { get; set; }
        //[ForeignKey("IdPrescription")]
        // public virtual Prescription Prescription{ get; set; }
    }
}
