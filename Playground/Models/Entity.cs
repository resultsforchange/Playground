using System.ComponentModel.DataAnnotations.Schema;
using Playground.Interfaces;

namespace Playground.Models
{
    public abstract class BaseEntity
    {
    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
    }
}