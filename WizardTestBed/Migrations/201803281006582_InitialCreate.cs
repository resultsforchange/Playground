namespace WizardTestBed.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organisation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vision = c.String(),
                        Mission = c.String(),
                        WomensRightsIssuesId = c.Int(nullable: false),
                        YearFormed = c.String(maxLength: 4),
                        Founder = c.String(maxLength: 255),
                        ReasonFormed = c.String(),
                        OperationalLocationId = c.Int(nullable: false),
                        OperationalAreaId = c.Int(nullable: false),
                        Achievements = c.String(),
                        InsertedDateTime = c.DateTime(nullable: false),
                        ModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Administration",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganisationId = c.Int(nullable: false),
                        Name = c.String(),
                        PhysicalAddressLine1 = c.String(),
                        PhysicalAddressLine2 = c.String(),
                        PhysicalCity = c.String(),
                        PhysicalCountry = c.Int(nullable: false),
                        PhysicalCode = c.String(),
                        PostalAddressLine1 = c.String(),
                        PostalAddressLine2 = c.String(),
                        PostalCity = c.String(),
                        PostalCountry = c.Int(nullable: false),
                        PostalCode = c.String(),
                        TelephoneNumber = c.String(),
                        MobileNumber = c.String(),
                        EmailAddress = c.String(),
                        WebsiteUrl = c.String(),
                        SkypeAddress = c.String(),
                        TwitterAccount = c.String(),
                        FacebookAccount = c.String(),
                        ContactName = c.String(),
                        ContactPosition = c.String(),
                        ContactTelephoneNumber = c.String(),
                        ContactEmailAddress = c.String(),
                        ContactSkypeAddress = c.String(),
                        LearntAboutId = c.Int(nullable: false),
                        ReceivedPreviousGrant = c.Boolean(nullable: false),
                        PreviousGrantInformationId = c.Int(nullable: false),
                        InsertedDateTime = c.DateTime(nullable: false),
                        ModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId, cascadeDelete: true)
                .Index(t => t.OrganisationId);
            
            CreateTable(
                "dbo.Structure",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganisationId = c.Int(nullable: false),
                        IsWomensRightsOrganisation = c.Boolean(nullable: false),
                        WomensRightsPhiliosophy = c.String(),
                        WomensRoleInDecisionMaking = c.String(),
                        HowAreKeyDecisionsMade = c.String(),
                        WomensRoleOnBoard = c.String(),
                        PaidStaffId = c.Int(nullable: false),
                        UnpaidStaffId = c.Int(nullable: false),
                        BoardId = c.Int(nullable: false),
                        AdvisorId = c.Int(nullable: false),
                        VolunteerId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RegistrationCertificate = c.Binary(),
                        ReferenceLetter = c.Binary(),
                        InsertedDateTime = c.DateTime(nullable: false),
                        ModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId, cascadeDelete: true)
                .Index(t => t.OrganisationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Structure", "OrganisationId", "dbo.Organisation");
            DropForeignKey("dbo.Administration", "OrganisationId", "dbo.Organisation");
            DropIndex("dbo.Structure", new[] { "OrganisationId" });
            DropIndex("dbo.Administration", new[] { "OrganisationId" });
            DropTable("dbo.Structure");
            DropTable("dbo.Administration");
            DropTable("dbo.Organisation");
        }
    }
}
