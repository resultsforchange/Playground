using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class WomensRightsIssue : AuditableEntity<int>
    {
        [Required]
        [MaxLength(128)]
        [Display(Name = "Women's Rights Issue")]
        public string Description { get; set; }
    }
}