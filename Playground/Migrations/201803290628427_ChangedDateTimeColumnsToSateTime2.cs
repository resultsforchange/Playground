namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateTimeColumnsToSateTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Country", "InsertedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Country", "ModifiedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Organisation", "InsertedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Organisation", "ModifiedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Administration", "InsertedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Administration", "ModifiedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Structure", "InsertedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Structure", "ModifiedDateTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Structure", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Structure", "InsertedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Administration", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Administration", "InsertedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Organisation", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Organisation", "InsertedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Country", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Country", "InsertedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
