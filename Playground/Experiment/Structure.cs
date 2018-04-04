namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Structure")]
    public partial class Structure
    {
        public long Id { get; set; }

        public long? OrganisationId { get; set; }

        public bool IsWomensRightsOrganisation { get; set; }

        [Required]
        public string WomensRightsPhiliosophy { get; set; }

        [Required]
        public string WomensRoleInDecisionMaking { get; set; }

        [Required]
        public string HowAreKeyDecisionsMade { get; set; }

        [Required]
        public string WomensRoleOnBoard { get; set; }

        public byte[] RegistrationCertificate { get; set; }

        public byte[] ReferenceLetter { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [StringLength(256)]
        public string InsertedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [StringLength(256)]
        public string ModifiedBy { get; set; }

        public int? PaidStaffTotal { get; set; }

        public int? PaidStaffFemales { get; set; }

        public int? PaidStaffMales { get; set; }

        public int? PaidStaffTransNonConforming { get; set; }

        public int? UnpaidStaffTotal { get; set; }

        public int? UnpaidStaffFemales { get; set; }

        public int? UnpaidStaffMales { get; set; }

        public int? UnpaidStaffTransNonConforming { get; set; }

        public int? BoardMembersTotal { get; set; }

        public int? BoardMembersFemales { get; set; }

        public int? BoardMembersMales { get; set; }

        public int? BoardMembersTransNonConforming { get; set; }

        public int? AdvisorsTotal { get; set; }

        public int? AdvisorsFemales { get; set; }

        public int? AdvisorsMales { get; set; }

        public int? AdvisorsTransNonConforming { get; set; }

        public int? VolunteersTotal { get; set; }

        public int? VolunteersFemales { get; set; }

        public int? VolunteersMales { get; set; }

        public int? VolunteersTransNonConforming { get; set; }

        public int? MembersTotal { get; set; }

        public int? MembersFemales { get; set; }

        public int? MembersMales { get; set; }

        public int? MembersTransNonConforming { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
