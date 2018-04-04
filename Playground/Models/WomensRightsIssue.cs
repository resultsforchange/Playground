using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class WomensRightsIssue : AuditableEntity<int>
    {
        public WomensRightsIssue()
        {
            Organisations = new HashSet<Organisation>();
        }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Women's Rights Issue")]
        public string Description { get; set; }

        public virtual ICollection<Organisation> Organisations { get; set; }
    }
}