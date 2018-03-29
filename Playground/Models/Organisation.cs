using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Organisation : BaseModel<int>
    {
        public string Vision { get; set; }
        public string Mission { get; set; }
        public int WomensRightsIssuesId { get; set; }
        [StringLength(4)]
        public string YearFormed { get; set; }
        [StringLength(255)]
        public string Founder { get; set; }
        public string ReasonFormed { get; set; }
        public int OperationalLocationId { get; set; }
        public int OperationalAreaId { get; set; }
        public string Achievements { get; set; }
    }
}
