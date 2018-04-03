namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WomensRightsIssue")]
    public partial class WomensRightsIssue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WomensRightsIssue()
        {
            Organisation = new HashSet<Organisation>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [StringLength(256)]
        public string InsertedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [StringLength(256)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organisation> Organisation { get; set; }
    }
}
