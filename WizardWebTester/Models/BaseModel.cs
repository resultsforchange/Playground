using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizardWebTester.Models
{
    public abstract class BaseModel<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
        [Required]
        public virtual DateTime InsertedDateTime { get; set; }
        [Required]
        public virtual DateTime ModifiedDateTime { get; set; }  
    }
}
