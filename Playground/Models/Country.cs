﻿using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Country : AuditableEntity<int>
    {
        [Required]
        [MaxLength(128)]
        [Display(Name = "Country Name")]
        public string Description { get; set; }
    }
}