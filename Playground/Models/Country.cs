using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Country : AuditableEntity<int>
    {
        public Country()
        {
            OperationalLocations = new HashSet<OperationalLocation>();
            AdministrationPhysical = new HashSet<Administration>();
            AdministrationPostal = new HashSet<Administration>();
        }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Country Name")]
        public string Description { get; set; }

        public virtual ICollection<OperationalLocation> OperationalLocations { get; set; }
        public virtual ICollection<Administration> AdministrationPhysical { get; set; }
        public virtual ICollection<Administration> AdministrationPostal { get; set; }
    }
}