namespace Playground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditionalStructureColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Structure", "PaidStaffTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "PaidStaffFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "PaidStaffMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "PaidStaffTransNonConforming", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "UnpaidStaffTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "UnpaidStaffFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "UnpaidStaffMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "UnpaidStaffTransNonConforming", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "BoardMembersTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "BoardMembersFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "BoardMembersMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "BoardMembersTransNonConforming", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "AdvisorsTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "AdvisorsFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "AdvisorsMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "AdvisorsTransNonConforming", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "VolunteersTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "VolunteersFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "VolunteersMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "VolunteersTransNonConforming", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "MembersTotal", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "MembersFemales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "MembersMales", c => c.Int(nullable: true));
            AddColumn("dbo.Structure", "MembersTransNonConforming", c => c.Int(nullable: true));
            DropColumn("dbo.Structure", "PaidStaffId");
            DropColumn("dbo.Structure", "UnpaidStaffId");
            DropColumn("dbo.Structure", "BoardId");
            DropColumn("dbo.Structure", "AdvisorId");
            DropColumn("dbo.Structure", "VolunteerId");
            DropColumn("dbo.Structure", "MemberId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Structure", "MemberId", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "VolunteerId", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "AdvisorId", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "BoardId", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "UnpaidStaffId", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "PaidStaffId", c => c.Int(nullable: false));
            DropColumn("dbo.Structure", "MembersTransNonConforming");
            DropColumn("dbo.Structure", "MembersMales");
            DropColumn("dbo.Structure", "MembersFemales");
            DropColumn("dbo.Structure", "MembersTotal");
            DropColumn("dbo.Structure", "VolunteersTransNonConforming");
            DropColumn("dbo.Structure", "VolunteersMales");
            DropColumn("dbo.Structure", "VolunteersFemales");
            DropColumn("dbo.Structure", "VolunteersTotal");
            DropColumn("dbo.Structure", "AdvisorsTransNonConforming");
            DropColumn("dbo.Structure", "AdvisorsMales");
            DropColumn("dbo.Structure", "AdvisorsFemales");
            DropColumn("dbo.Structure", "AdvisorsTotal");
            DropColumn("dbo.Structure", "BoardMembersTransNonConforming");
            DropColumn("dbo.Structure", "BoardMembersMales");
            DropColumn("dbo.Structure", "BoardMembersFemales");
            DropColumn("dbo.Structure", "BoardMembersTotal");
            DropColumn("dbo.Structure", "UnpaidStaffTransNonConforming");
            DropColumn("dbo.Structure", "UnpaidStaffMales");
            DropColumn("dbo.Structure", "UnpaidStaffFemales");
            DropColumn("dbo.Structure", "UnpaidStaffTotal");
            DropColumn("dbo.Structure", "PaidStaffTransNonConforming");
            DropColumn("dbo.Structure", "PaidStaffMales");
            DropColumn("dbo.Structure", "PaidStaffFemales");
            DropColumn("dbo.Structure", "PaidStaffTotal");
        }
    }
}
