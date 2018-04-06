namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                .ForeignKey("dbo.LearntAbout", t => t.LearntAboutId)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId)
                .ForeignKey("dbo.Country", t => t.PhysicalCountry, cascadeDelete: false)
                .ForeignKey("dbo.Country", t => t.PostalCountry, cascadeDelete: false)
                .Index(t => t.OrganisationId)
                .Index(t => t.PhysicalCountry)
                .Index(t => t.PostalCountry)
                .Index(t => t.LearntAboutId);
            
            CreateTable(
                "dbo.LearntAbout",
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OperationalArea", t => t.OperationalAreaId)
                .ForeignKey("dbo.WomensRightsIssue", t => t.WomensRightsIssuesId)
                .Index(t => t.WomensRightsIssuesId)
                .Index(t => t.OperationalAreaId);
            
            CreateTable(
                "dbo.OperationalArea",
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
            
            CreateTable(
                "dbo.OperationalLocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganisationId = c.Long(nullable: false),
                        OperationalAreaId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        Location = c.String(nullable: false, maxLength: 256),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId)
                .ForeignKey("dbo.OperationalArea", t => t.OperationalAreaId)
                .ForeignKey("dbo.Organisation", t => t.OrganisationId)
                .Index(t => t.OrganisationId)
                .Index(t => t.OperationalAreaId)
                .Index(t => t.CountryId);
            
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
                        PaidStaffTotal = c.Int(nullable: false),
                        PaidStaffFemales = c.Int(nullable: false),
                        PaidStaffMales = c.Int(nullable: false),
                        PaidStaffTransNonConforming = c.Int(nullable: false),
                        UnpaidStaffTotal = c.Int(nullable: false),
                        UnpaidStaffFemales = c.Int(nullable: false),
                        UnpaidStaffMales = c.Int(nullable: false),
                        UnpaidStaffTransNonConforming = c.Int(nullable: false),
                        BoardMembersTotal = c.Int(nullable: false),
                        BoardMembersFemales = c.Int(nullable: false),
                        BoardMembersMales = c.Int(nullable: false),
                        BoardMembersTransNonConforming = c.Int(nullable: false),
                        AdvisorsTotal = c.Int(nullable: false),
                        AdvisorsFemales = c.Int(nullable: false),
                        AdvisorsMales = c.Int(nullable: false),
                        AdvisorsTransNonConforming = c.Int(nullable: false),
                        VolunteersTotal = c.Int(nullable: false),
                        VolunteersFemales = c.Int(nullable: false),
                        VolunteersMales = c.Int(nullable: false),
                        VolunteersTransNonConforming = c.Int(nullable: false),
                        MembersTotal = c.Int(nullable: false),
                        MembersFemales = c.Int(nullable: false),
                        MembersMales = c.Int(nullable: false),
                        MembersTransNonConforming = c.Int(nullable: false),
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
                "dbo.File",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        StructureId = c.Long(nullable: false),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Structure", t => t.StructureId)
                .Index(t => t.StructureId);
            
            CreateTable(
                "dbo.WomensRightsIssue",
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
            
            CreateTable(
                "dbo.PreviousGrantsInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdministrationId = c.Long(nullable: false),
                        ProjectName = c.String(nullable: false, maxLength: 256),
                        GrantId = c.String(nullable: false, maxLength: 16),
                        KeyOutcomes = c.String(nullable: false),
                        InsertedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        InsertedBy = c.String(maxLength: 256),
                        ModifiedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administration", t => t.AdministrationId)
                .Index(t => t.AdministrationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PreviousGrantsInformation", "AdministrationId", "dbo.Administration");
            DropForeignKey("dbo.Organisation", "WomensRightsIssuesId", "dbo.WomensRightsIssue");
            DropForeignKey("dbo.Structure", "OrganisationId", "dbo.Organisation");
            DropForeignKey("dbo.File", "StructureId", "dbo.Structure");
            DropForeignKey("dbo.OperationalLocation", "OrganisationId", "dbo.Organisation");
            DropForeignKey("dbo.Organisation", "OperationalAreaId", "dbo.OperationalArea");
            DropForeignKey("dbo.OperationalLocation", "OperationalAreaId", "dbo.OperationalArea");
            DropForeignKey("dbo.OperationalLocation", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Administration", "PostalCountry", "dbo.Country");
            DropForeignKey("dbo.Administration", "PhysicalCountry", "dbo.Country");
            DropForeignKey("dbo.Administration", "OrganisationId", "dbo.Organisation");
            DropForeignKey("dbo.Administration", "LearntAboutId", "dbo.LearntAbout");
            DropIndex("dbo.PreviousGrantsInformation", new[] { "AdministrationId" });
            DropIndex("dbo.File", new[] { "StructureId" });
            DropIndex("dbo.Structure", new[] { "OrganisationId" });
            DropIndex("dbo.OperationalLocation", new[] { "CountryId" });
            DropIndex("dbo.OperationalLocation", new[] { "OperationalAreaId" });
            DropIndex("dbo.OperationalLocation", new[] { "OrganisationId" });
            DropIndex("dbo.Organisation", new[] { "OperationalAreaId" });
            DropIndex("dbo.Organisation", new[] { "WomensRightsIssuesId" });
            DropIndex("dbo.Administration", new[] { "LearntAboutId" });
            DropIndex("dbo.Administration", new[] { "PostalCountry" });
            DropIndex("dbo.Administration", new[] { "PhysicalCountry" });
            DropIndex("dbo.Administration", new[] { "OrganisationId" });
            DropTable("dbo.PreviousGrantsInformation");
            DropTable("dbo.WomensRightsIssue");
            DropTable("dbo.File");
            DropTable("dbo.Structure");
            DropTable("dbo.Country");
            DropTable("dbo.OperationalLocation");
            DropTable("dbo.OperationalArea");
            DropTable("dbo.Organisation");
            DropTable("dbo.LearntAbout");
            DropTable("dbo.Administration");
        }
    }
}
