using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizardWebTester.Models
{
    public abstract class LookupBaseModel<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
        [Required, MaxLength(255)]
        public virtual string Description { get; set; }
        [Required]
        public virtual DateTime InsertedDateTime { get; set; }
        [Required]
        public virtual DateTime ModifiedDateTime { get; set; }
    }
}