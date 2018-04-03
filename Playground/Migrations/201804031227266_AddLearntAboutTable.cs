namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLearntAboutTable : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.OperationalArea", "Organisation_Id", c => c.Long());
            CreateIndex("dbo.OperationalArea", "Organisation_Id");
            AddForeignKey("dbo.OperationalArea", "Organisation_Id", "dbo.Organisation", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OperationalArea", "Organisation_Id", "dbo.Organisation");
            DropIndex("dbo.OperationalArea", new[] { "Organisation_Id" });
            DropColumn("dbo.OperationalArea", "Organisation_Id");
            DropTable("dbo.LearntAbout");
        }
    }
}
