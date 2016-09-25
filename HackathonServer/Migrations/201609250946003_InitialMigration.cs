namespace HackathonServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EducationFacility");
            DropTable("dbo.BusStopDto");

            CreateTable(
                "dbo.BusStopDto",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Y = c.Double(nullable: false),
                    X = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.Id);

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
                    UsersCategory = c.String(),
                    AudienceType = c.String(),
                    Longitude = c.Double(nullable: false),
                    Latitude = c.Double(nullable: false),
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
