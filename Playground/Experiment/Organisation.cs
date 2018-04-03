namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organisation")]
    public partial class Organisation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organisation()
        {
            Administration = new HashSet<Administration>();
            OperationalLocation = new HashSet<OperationalLocation>();
            Structure = new HashSet<Structure>();
        }

        public long Id { get; set; }

        [Required]
        public string Vision { get; set; }

        [Required]
        public string Mission { get; set; }

        public int WomensRightsIssuesId { get; set; }

        [Required]
        [StringLength(4)]
        public string YearFormed { get; set; }

        [Required]
        [StringLength(255)]
        public string Founder { get; set; }

        [Required]
        public string ReasonFormed { get; set; }

        public int OperationalLocationId { get; set; }

        public int OperationalAreaId { get; set; }

        [Required]
        public string Achievements { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [StringLength(256)]
        public string InsertedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [StringLength(256)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administration> Administration { get; set; }

        public virtual OperationalArea OperationalArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationalLocation> OperationalLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Structure> Structure { get; set; }

        public virtual WomensRightsIssue WomensRightsIssue { get; set; }
    }
}
