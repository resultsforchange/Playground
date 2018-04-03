using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Playground.Interfaces;

namespace Playground.Models
{
    /// <summary>
    /// ScaffoldColumn(false) is used So that ASP.NET MVC Scaffolding will 
    /// NOT generate controls for this in Views. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime InsertedDateTime { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string InsertedBy { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDateTime { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string ModifiedBy { get; set; }
    }
}