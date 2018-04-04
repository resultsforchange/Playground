using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class OperationalLocation : AuditableEntity<int>
    {
        public long OrganisationId { get; set; }

        public int OperationalAreaId { get; set; }

        public int CountryId { get; set; }

        [Required]
        [StringLength(256)]
        public string Location { get; set; }

        public virtual Country Country { get; set; }
        public virtual OperationalArea OperationalArea { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}