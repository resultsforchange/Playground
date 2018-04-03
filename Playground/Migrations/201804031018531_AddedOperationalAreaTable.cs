namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOperationalAreaTable : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OperationalArea");
        }
    }
}
