using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    [Table("Organisation")]
    public class Organisation : AuditableEntity<long>
    {
        public Organisation()
        {
            Administration = new HashSet<Administration>();
            Structure = new HashSet<Structure>();
            OperationalArea = new HashSet<OperationalArea>();
        }

        [Required]
        [MaxLength(int.MaxValue)]
        public string Vision { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        public string Mission { get; set; }

        [Display(Name="Women's Rights Issues")]
        public int WomensRightsIssuesId { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name = "In which year was your organisation formed?")]
        public string YearFormed { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Who founded your organisation?")]
        public string Founder { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        [Display(Name = "Why was your organisation formed?")]
        public string ReasonFormed { get; set; }

        [Required]
        [Display(Name = "Operational Location")]
        public int OperationalLocationId { get; set; }

        [Required]
        [Display(Name = "Operational Area")]
        public int OperationalAreaId { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        [Display(Name = "Name a few achievements of your organisation")]
        public string Achievements { get; set; }

        public virtual ICollection<Administration> Administration { get; set; }
        public virtual ICollection<Structure> Structure { get; set; }   
        public virtual ICollection<OperationalArea> OperationalArea { get; set; }
    }
}
