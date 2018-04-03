using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    [Table("Administration")]
    public class Administration : AuditableEntity<long>
    {
        //[ScaffoldColumn(false)]
        [Required]
        public long OrganisationId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Physical address line 1")]
        public string PhysicalAddressLine1 { get; set; }

        [MaxLength(256)]
        [Display(Name = "Physical address line 2")]
        public string PhysicalAddressLine2 { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "City")]
        public string PhysicalCity { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int PhysicalCountry { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string PhysicalCode { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Postal address line 1")]
        public string PostalAddressLine1 { get; set; }

        [MaxLength(256)]
        [Display(Name = "Postal address line 2")]
        public string PostalAddressLine2 { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "City")]
        public string PostalCity { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int PostalCountry { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Telephone number")]
        public string TelephoneNumber { get; set; }

        [Display(Name = "Mobile number")]
        public string MobileNumber { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Website address")]
        [RegularExpression(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$")]
        public string WebsiteUrl { get; set; }

        [Display(Name = "Skype address")]
        public string SkypeAddress { get; set; }

        [Display(Name = "Twitter account")]
        public string TwitterAccount { get; set; }

        [Display(Name = "Facebook account")]
        public string FacebookAccount { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Contact name")]
        public string ContactName { get; set; }

        [MaxLength(256)]
        [Display(Name = "Contact position")]
        public string ContactPosition { get; set; }

        [Required]
        [Display(Name = "Contact telephone number")]
        public string ContactTelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Contact email address")]
        public string ContactEmailAddress { get; set; }

        [Display(Name = "Contact Skype address")]
        public string ContactSkypeAddress { get; set; }

        [Required]
        [Display(Name = "How did you learn about the AWDF?")]
        public int LearntAboutId { get; set; }

        [Required]
        [Display(Name = "Have you previously received a grant from the AWDF?")]
        public bool ReceivedPreviousGrant { get; set; }

        [Display(Name = "Previous grant information")]
        public int PreviousGrantInformationId { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
