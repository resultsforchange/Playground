using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class PreviousGrantsInformation : AuditableEntity<int>
    {   
        public long AdministrationId { get; set; }

        [Required]
        [StringLength(256)]
        public string ProjectName { get; set; }

        [Required]
        [StringLength(16)]
        public string GrantId { get; set; }

        [Required]
        [StringLength(int.MaxValue)]
        public string KeyOutcomes { get; set; } 

        public virtual Administration Administration { get; set; }
    }
}