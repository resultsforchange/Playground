using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class LearntAbout : AuditableEntity<int>
    {
        public LearntAbout()
        {
            Administration = new HashSet<Administration>();
        }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Learnt About AWDF")]
        public string Description { get; set; }

        public virtual ICollection<Administration> Administration { get; set; }
    }
}