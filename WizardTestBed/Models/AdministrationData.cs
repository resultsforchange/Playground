using System;

namespace WizardTestBed.models
{
    public class AdministrationData
    {
        public int AdministrationId { get; set; } // AdministrationId (Primary key)
        public int OrganisationId { get; set; } // OrganisationId
        public string Name { get; set; } // Name
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
        public string TelephoneNumber { get; set; } // TelephoneNumber
        public string MobileNumber { get; set; } // MobileNumber
        public string EmailAddress { get; set; } // EmailAddress
        public string WebsiteUrl { get; set; } // WebsiteUrl
        public string SkypeAddress { get; set; } // SkypeAddress
        public string TwitterAccount { get; set; } // TwitterAccount
        public string FacebookAccount { get; set; } // FacebookAccount
        public string ContactName { get; set; } // ContactName
        public string ContactPosition { get; set; } // ContactPosition
        public string ContactTelephoneNumber { get; set; } // ContactTelephoneNumber
        public string ContactEmailAddress { get; set; } // ContactEmailAddress
        public string ContactSkypeAddress { get; set; } // ContactSkypeAddress
        public int LearntAboutId { get; set; } // LearntAboutId
        public bool ReceivedPreviousGrant { get; set; } // ReceivedPreviousGrant
        public int PreviousGrantInformationId { get; set; } // PreviousGrantInformationId
        public DateTime InsertedDateTime { get; set; } // InsertedDateTime
        public DateTime ModifiedDateTime { get; set; } // ModifiedDateTime
    }
}
