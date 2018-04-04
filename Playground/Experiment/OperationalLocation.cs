namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationalLocation")]
    public partial class OperationalLocation
    {
        public int Id { get; set; }

        public long OrganisationId { get; set; }

        public int OperationalAreaId { get; set; }

        public int CountryId { get; set; }

        [Required]
        [StringLength(256)]
        public string Location { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [StringLength(256)]
        public string InsertedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [StringLength(256)]
        public string ModifiedBy { get; set; }

        public virtual Country Country { get; set; }

        public virtual OperationalArea OperationalArea { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
