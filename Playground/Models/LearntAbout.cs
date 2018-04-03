using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class LearntAbout : AuditableEntity<int>
    {
        [Required]
        [MaxLength(128)]
        [Display(Name = "Learnt About AWDF")]
        public string Description { get; set; }
    }
}