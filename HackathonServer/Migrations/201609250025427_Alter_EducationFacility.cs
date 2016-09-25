namespace HackathonServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_EducationFacility : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EducationFacilityDto", newName: "EducationFacility");
            AddColumn("dbo.EducationFacility", "UsersCategory", c => c.String());
            AddColumn("dbo.EducationFacility", "AudienceType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EducationFacility", "AudienceType");
            DropColumn("dbo.EducationFacility", "UsersCategory");
            RenameTable(name: "dbo.EducationFacility", newName: "EducationFacilityDto");
        }
    }
}
