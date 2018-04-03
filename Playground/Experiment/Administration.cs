namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administration")]
    public partial class Administration
    {
        public long Id { get; set; }

        public long? OrganisationId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string PhysicalAddressLine1 { get; set; }

        [StringLength(256)]
        public string PhysicalAddressLine2 { get; set; }

        [Required]
        [StringLength(256)]
        public string PhysicalCity { get; set; }

        public int PhysicalCountry { get; set; }

        [Required]
        public string PhysicalCode { get; set; }

        [Required]
        [StringLength(256)]
        public string PostalAddressLine1 { get; set; }

        [StringLength(256)]
        public string PostalAddressLine2 { get; set; }

        [Required]
        [StringLength(256)]
        public string PostalCity { get; set; }

        public int PostalCountry { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string TelephoneNumber { get; set; }

        public string MobileNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public string WebsiteUrl { get; set; }

        public string SkypeAddress { get; set; }

        public string TwitterAccount { get; set; }

        public string FacebookAccount { get; set; }

        [Required]
        [StringLength(256)]
        public string ContactName { get; set; }

        [StringLength(256)]
        public string ContactPosition { get; set; }

        [Required]
        public string ContactTelephoneNumber { get; set; }

        [Required]
        public string ContactEmailAddress { get; set; }

        public string ContactSkypeAddress { get; set; }

        public int LearntAboutId { get; set; }

        public bool ReceivedPreviousGrant { get; set; }

        public int PreviousGrantInformationId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [StringLength(256)]
        public string InsertedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [StringLength(256)]
        public string ModifiedBy { get; set; }

        public virtual Country Country { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
