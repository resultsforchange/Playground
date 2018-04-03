namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administration",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrganisationId = c.Long(),
                        Name = c.String(nullable: false, maxLength: 256),
                        PhysicalAddressLine1 = c.String(nullable: false, maxLength: 256),
                        PhysicalAddressLine2 = c.String(maxLength: 256),
                        PhysicalCity = c.String(nullable: false, maxLength: 256),
                        PhysicalCountry = c.Int(nullable: false),
                        PhysicalCode = c.String(nullable: false),
                        PostalAddressLine1 = c.String(nullable: false, maxLength: 256),
                        PostalAddressLine2 = c.String(maxLength: 256),
                        PostalCity = c.String(nullable: false, maxLength: 256),
                        PostalCountry = c.Int(nullable: false),
                        PostalCode = c.String(nullable: false),
                        TelephoneNumber = c.String(nullable: false),
                        MobileNumber = c.String(),
                        EmailAddress = c.String(nullable: false),
                        WebsiteUrl = c.String(),
                        SkypeAddress = c.String(),
                        TwitterAccount = c.String(),
                        FacebookAccount = c.String(),
                        ContactName = c.String(nullable: false, maxLength: 256),
                        ContactPosition = c.String(maxLength: 256),
                        ContactTelephoneNumber = c.String(nullable: false),
                        ContactEmailAddress = c.String(nullable: false),
                        ContactSkypeAddress = c.String(),
                        LearntAboutId = c.Int(nullable: false),
                        ReceivedPreviousGrant = c.Boolean(nullable: false),
                        PreviousGrantInformationId = c.Int(nullable: false),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId)
                .Index(t => t.OrganisationId);
            
            CreateTable(
                "dbo.Organisation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Vision = c.String(nullable: false),
                        Mission = c.String(nullable: false),
                        WomensRightsIssuesId = c.Int(nullable: false),
                        YearFormed = c.String(nullable: false, maxLength: 4),
                        Founder = c.String(nullable: false, maxLength: 255),
                        ReasonFormed = c.String(nullable: false),
                        OperationalLocationId = c.Int(nullable: false),
                        OperationalAreaId = c.Int(nullable: false),
                        Achievements = c.String(nullable: false),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Structure",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrganisationId = c.Long(),
                        IsWomensRightsOrganisation = c.Boolean(nullable: false),
                        WomensRightsPhiliosophy = c.String(nullable: false),
                        WomensRoleInDecisionMaking = c.String(nullable: false),
                        HowAreKeyDecisionsMade = c.String(nullable: false),
                        WomensRoleOnBoard = c.String(nullable: false),
                        PaidStaffId = c.Int(nullable: false),
                        UnpaidStaffId = c.Int(nullable: false),
                        BoardId = c.Int(nullable: false),
                        AdvisorId = c.Int(nullable: false),
                        VolunteerId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RegistrationCertificate = c.Binary(),
                        ReferenceLetter = c.Binary(),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId)
                .Index(t => t.OrganisationId);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 128),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Structure", "OrganisationId", "dbo.Organisation");
            DropForeignKey("dbo.Administration", "OrganisationId", "dbo.Organisation");
            DropIndex("dbo.Structure", new[] { "OrganisationId" });
            DropIndex("dbo.Administration", new[] { "OrganisationId" });
            DropTable("dbo.Country");
            DropTable("dbo.Structure");
            DropTable("dbo.Organisation");
            DropTable("dbo.Administration");
        }
    }
}
