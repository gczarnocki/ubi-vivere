namespace HackathonServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EducationFacilityDtoes",
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
            DropTable("dbo.EducationFacilityDtoes");
        }
    }
}
