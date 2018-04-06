using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    [Table("Structure")]
    public class Structure : AuditableEntity<long>
    {
        public Structure()
        {
            Files = new HashSet<File>();
        }

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

        [Display(Name = "Paid staff total")]
        public int PaidStaffTotal { get; set; }

        [Display(Name = "Paid staff No. Women/Girls")]
        public int PaidStaffFemales { get; set; }

        [Display(Name = "Paid staff No. Men/Boys")]
        public int PaidStaffMales { get; set; }

        [Display(Name = "Paid staff No. Transgnder/Gender non-conforming")]
        public int PaidStaffTransNonConforming { get; set; }

        [Display(Name = "Unpaid staff total")]
        public int UnpaidStaffTotal { get; set; }

        [Display(Name = "Unpaid staff No. Women/Girls")]
        public int UnpaidStaffFemales { get; set; }

        [Display(Name = "Unpaid staff No. Men/Boys")]
        public int UnpaidStaffMales { get; set; }

        [Display(Name = "Unpaid staff No. Transgnder/Gender non-conforming")]
        public int UnpaidStaffTransNonConforming { get; set; }

        [Display(Name = "Board members total")]
        public int BoardMembersTotal { get; set; }

        [Display(Name = "Board members No. Women/Girls")]
        public int BoardMembersFemales { get; set; }

        [Display(Name = "Board members No. Men/Boys")]
        public int BoardMembersMales { get; set; }

        [Display(Name = "Board members No. Transgnder/Gender non-conforming")]
        public int BoardMembersTransNonConforming { get; set; }

        [Display(Name = "Advisors total")]
        public int AdvisorsTotal { get; set; }

        [Display(Name = "Advisors No. Women/Girls")]
        public int AdvisorsFemales { get; set; }

        [Display(Name = "Advisors No. Men/Boys")]
        public int AdvisorsMales { get; set; }

        [Display(Name = "Advisors No. Transgnder/Gender non-conforming")]
        public int AdvisorsTransNonConforming { get; set; }

        [Display(Name = "Volunteers total")]
        public int VolunteersTotal { get; set; }

        [Display(Name = "Volunteers No. Women/Girls")]
        public int VolunteersFemales { get; set; }

        [Display(Name = "Volunteers No. Men/Boys")]
        public int VolunteersMales { get; set; }

        [Display(Name = "Volunteers No. Transgnder/Gender non-conforming")]
        public int VolunteersTransNonConforming { get; set; }

        [Display(Name = "Members total")]
        public int MembersTotal { get; set; }

        [Display(Name = "Members No. Women/Girls")]
        public int MembersFemales { get; set; }

        [Display(Name = "Members No. Men/Boys")]
        public int MembersMales { get; set; }

        [Display(Name = "Members No. Transgnder/Gender non-conforming")]
        public int MembersTransNonConforming { get; set; }

        //[Required]
        [Display(Name = "Please upload your organisation's reqistration certificate")]
        //public byte[] RegistrationCertificate { get; set; }
        public byte[] RegistrationCertificate { get; set; }

        //[Required]
        [Display(Name = "Please upload a reference letter for your organisation")]
        public byte[] ReferenceLetter { get; set; }

        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
