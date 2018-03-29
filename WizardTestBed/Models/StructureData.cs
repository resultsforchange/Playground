using System;

namespace WizardTestBed.models
{
    public class StructureData
    {
        public int StructureId { get; set; } // StructureId (Primary key)
        public int OrganisationId { get; set; } // OrganisationId
        public bool IsWomensRightsOrganisation { get; set; } // IsWomensRightsOrganisation
        public string WomensRightsPhiliosophy { get; set; } // WomensRightsPhiliosophy
        public string WomensRoleInDecisionMaking { get; set; } // WomensRoleInDecisionMaking
        public string HowAreKeyDecisionsMade { get; set; } // HowAreKeyDecisionsMade
        public string WomensRoleOnBoard { get; set; } // WomensRoleOnBoard
        public int PaidStaffId { get; set; } // PaidStaffId
        public int UnpaidStaffId { get; set; } // UnpaidStaffId
        public int BoardId { get; set; } // BoardId
        public int AdvisorId { get; set; } // AdvisorId
        public int VolunteerId { get; set; } // VolunteerId
        public int MemberId { get; set; } // MemberId
        public byte[] RegistrationCertificate { get; set; } // RegistrationCertificate (length: 50)
        public byte[] ReferenceLetter { get; set; } // ReferenceLetter (length: 50)
        public DateTime InsertedDateTime { get; set; } // InsertedDateTime
        public DateTime ModifiedDateTime { get; set; } // ModifiedDateTime
    }
}
