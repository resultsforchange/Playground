using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class OperationalArea : AuditableEntity<int>
    {
        public OperationalArea()
        {
            Organisations = new HashSet<Organisation>();
            OperationalLocations = new HashSet<OperationalLocation>();
        }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Region")]
        public string Description { get; set; }

        public virtual ICollection<Organisation> Organisations { get; set; }
        public virtual ICollection<OperationalLocation> OperationalLocations { get; set; }
    }
}