using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    public abstract class LookupBaseModel<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
        [Required]
        public virtual string Description { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public virtual DateTime InsertedDateTime { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public virtual DateTime ModifiedDateTime { get; set; }
    }
}