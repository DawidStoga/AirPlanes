namespace AirPlane.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ctxConf : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AirlineAircrafts", "Airline_AirlineId", "dbo.Airlines");
            DropForeignKey("dbo.AirlineAircrafts", "Aircraft_AircraftID", "dbo.Aircraft");
            DropIndex("dbo.AirlineAircrafts", new[] { "Airline_AirlineId" });
            DropIndex("dbo.AirlineAircrafts", new[] { "Aircraft_AircraftID" });
            AddColumn("dbo.Aircraft", "AirLines_AirlineId", c => c.Int());
            CreateIndex("dbo.Aircraft", "AirLines_AirlineId");
            AddForeignKey("dbo.Aircraft", "AirLines_AirlineId", "dbo.Airlines", "AirlineId");
            DropTable("dbo.AirlineAircrafts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AirlineAircrafts",
                c => new
                    {
                        Airline_AirlineId = c.Int(nullable: false),
                        Aircraft_AircraftID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Airline_AirlineId, t.Aircraft_AircraftID });
            
            DropForeignKey("dbo.Aircraft", "AirLines_AirlineId", "dbo.Airlines");
            DropIndex("dbo.Aircraft", new[] { "AirLines_AirlineId" });
            DropColumn("dbo.Aircraft", "AirLines_AirlineId");
            CreateIndex("dbo.AirlineAircrafts", "Aircraft_AircraftID");
            CreateIndex("dbo.AirlineAircrafts", "Airline_AirlineId");
            AddForeignKey("dbo.AirlineAircrafts", "Aircraft_AircraftID", "dbo.Aircraft", "AircraftID", cascadeDelete: true);
            AddForeignKey("dbo.AirlineAircrafts", "Airline_AirlineId", "dbo.Airlines", "AirlineId", cascadeDelete: true);
        }
    }
}
