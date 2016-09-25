namespace HackathonServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusStopDto",
                c => new
                    {
                        Y = c.Double(nullable: false),
                        X = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.Y, t.X });
            
            CreateTable(
                "dbo.EducationFacility",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        StreetNumber = c.String(),
                        HomeNumber = c.String(),
                        Postcode = c.String(),
                        Telephone = c.String(),
                        FacilityType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EducationFacility");
            DropTable("dbo.BusStopDto");
        }
    }
}
