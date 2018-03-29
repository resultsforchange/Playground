namespace WizardTestBed.Models
{
    public class Structure : BaseModel<int>
    {
        public int OrganisationId { get; set; }
        public bool IsWomensRightsOrganisation { get; set; }
        public string WomensRightsPhiliosophy { get; set; }
        public string WomensRoleInDecisionMaking { get; set; }
        public string HowAreKeyDecisionsMade { get; set; }
        public string WomensRoleOnBoard { get; set; }
        public int PaidStaffId { get; set; }
        public int UnpaidStaffId { get; set; }
        public int BoardId { get; set; }
        public int AdvisorId { get; set; }
        public int VolunteerId { get; set; }
        public int MemberId { get; set; }
        public byte[] RegistrationCertificate { get; set; }
        public byte[] ReferenceLetter { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
