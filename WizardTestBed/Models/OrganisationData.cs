using System;

namespace WizardTestBed.models
{
    public class OrganisationData
    {
        public int OrganisationId { get; set; } // OrganisationId (Primary key)
        public string Vision { get; set; } // Vision
        public string Mission { get; set; } // Mission
        public int WomensRightsIssuesId { get; set; } // WomensRightsIssuesId
        public DateTime YearFormed { get; set; } // YearFormed
        public string Founder { get; set; } // Founder (length: 255)
        public string ReasonFormed { get; set; } // ReasonFormed
        public int OperationalLocationId { get; set; } // OperationalLocationId
        public int OperationalAreaId { get; set; } // OperationalAreaId
        public string Achievements { get; set; } // Achievements
        public DateTime InsertedDateTime { get; set; } // InsertedDateTime
        public DateTime ModifiedDateTime { get; set; } // ModifiedDateTime
    }
}
