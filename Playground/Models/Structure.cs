using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    [Table("Structure")]
    public class Structure : AuditableEntity<long>
    {
        //[ScaffoldColumn(false)]
        public long OrganisationId { get; set; }

        [Required]
        [Display(Name = "Is your organisation a women's rights organisation?")]
        public bool IsWomensRightsOrganisation { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        [Display(Name = "Please explain your organisation's women's rights philosophy")]
        public string WomensRightsPhiliosophy { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        [Display(Name = "What role do women play in your organsation's decision making process?")]
        public string WomensRoleInDecisionMaking { get; set; }

        [Required]
        [Display(Name = "How are key decisions made in your organisation?")]
        public string HowAreKeyDecisionsMade { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        [Display(Name = "What are women's role on your board?")]
        public string WomensRoleOnBoard { get; set; }

        [Required]
        [Display(Name = "Paid staff information")]
        public int PaidStaffId { get; set; }

        [Required]
        [Display(Name = "Unpaid staff information")]
        public int UnpaidStaffId { get; set; }

        [Required]
        [Display(Name = "Board information")]
        public int BoardId { get; set; }

        [Required]
        [Display(Name = "Advisors information")]
        public int AdvisorId { get; set; }

        [Required]
        [Display(Name = "Volunteer information")]
        public int VolunteerId { get; set; }

        [Required]
        [Display(Name = "Member information")]
        public int MemberId { get; set; }

        //[Required]
        [Display(Name = "Please upload your organisation's reqistration certificate")]
        public byte[] RegistrationCertificate { get; set; }

        //[Required]
        [Display(Name = "Please upload a reference letter for your organisation")]
        public byte[] ReferenceLetter { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
