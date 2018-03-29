using System.ComponentModel.DataAnnotations;

namespace WizardTestBed.Models
{
    public class Administration : BaseModel<int>
    {
        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public string PhysicalAddressLine1 { get; set; }
        public string PhysicalAddressLine2 { get; set; }
        public string PhysicalCity { get; set; }
        public int PhysicalCountry { get; set; }
        public string PhysicalCode { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalCity { get; set; }
        public int PostalCountry { get; set; }
        public string PostalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string EmailAddress { get; set; }
        [RegularExpression(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$")]
        public string WebsiteUrl { get; set; }
        public string SkypeAddress { get; set; }
        public string TwitterAccount { get; set; }
        public string FacebookAccount { get; set; }
        public string ContactName { get; set; }
        public string ContactPosition { get; set; }
        public string ContactTelephoneNumber { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactSkypeAddress { get; set; }
        public int LearntAboutId { get; set; }
        public bool ReceivedPreviousGrant { get; set; }
        public int PreviousGrantInformationId { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
