namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Administration = new HashSet<Administration>();
            Administration1 = new HashSet<Administration>();
            OperationalLocation = new HashSet<OperationalLocation>();
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
        public virtual ICollection<Administration> Administration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administration> Administration1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationalLocation> OperationalLocation { get; set; }
    }
}
