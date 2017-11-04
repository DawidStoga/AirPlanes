namespace AirPlane.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newPhoto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aircraft", "AirLines_AirlineId", "dbo.Airlines");
            DropIndex("dbo.Aircraft", new[] { "AirLines_AirlineId" });
            CreateTable(
                "dbo.AirlineAircrafts",
                c => new
                    {
                        Airline_AirlineId = c.Int(nullable: false),
                        Aircraft_AircraftID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Airline_AirlineId, t.Aircraft_AircraftID })
                .ForeignKey("dbo.Airlines", t => t.Airline_AirlineId, cascadeDelete: true)
                .ForeignKey("dbo.Aircraft", t => t.Aircraft_AircraftID, cascadeDelete: true)
                .Index(t => t.Airline_AirlineId)
                .Index(t => t.Aircraft_AircraftID);
            
            DropColumn("dbo.Aircraft", "AirLines_AirlineId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aircraft", "AirLines_AirlineId", c => c.Int());
            DropForeignKey("dbo.AirlineAircrafts", "Aircraft_AircraftID", "dbo.Aircraft");
            DropForeignKey("dbo.AirlineAircrafts", "Airline_AirlineId", "dbo.Airlines");
            DropIndex("dbo.AirlineAircrafts", new[] { "Aircraft_AircraftID" });
            DropIndex("dbo.AirlineAircrafts", new[] { "Airline_AirlineId" });
            DropTable("dbo.AirlineAircrafts");
            CreateIndex("dbo.Aircraft", "AirLines_AirlineId");
            AddForeignKey("dbo.Aircraft", "AirLines_AirlineId", "dbo.Airlines", "AirlineId");
        }
    }
}
