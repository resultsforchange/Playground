using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class OperationalArea : AuditableEntity<int>
    {
        [Required]
        [MaxLength(128)]
        [Display(Name = "Region")]
        public string Description { get; set; }
    }
}