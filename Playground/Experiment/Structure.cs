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

        public int PaidStaffId { get; set; }

        public int UnpaidStaffId { get; set; }

        public int BoardId { get; set; }

        public int AdvisorId { get; set; }

        public int VolunteerId { get; set; }

        public int MemberId { get; set; }

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

        public virtual Organisation Organisation { get; set; }
    }
}
