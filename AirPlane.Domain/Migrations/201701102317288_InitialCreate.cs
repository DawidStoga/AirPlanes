namespace AirPlane.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aircraft",
                c => new
                    {
                        AircraftID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Category = c.String(),
                        EngineCnt = c.Int(nullable: false),
                        ImageURl = c.String(),
                        ThumbnailBits = c.Binary(),
                    })
                .PrimaryKey(t => t.AircraftID);
            
            CreateTable(
                "dbo.PhotoFullImages",
                c => new
                    {
                        PhotoFullImageId = c.Int(nullable: false),
                        HighResolutionBits = c.Binary(),
                    })
                .PrimaryKey(t => t.PhotoFullImageId)
                .ForeignKey("dbo.Aircraft", t => t.PhotoFullImageId)
                .Index(t => t.PhotoFullImageId);
            
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        AirlineId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.AirlineId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropForeignKey("dbo.AirlineAircrafts", "Aircraft_AircraftID", "dbo.Aircraft");
            DropForeignKey("dbo.AirlineAircrafts", "Airline_AirlineId", "dbo.Airlines");
            DropForeignKey("dbo.PhotoFullImages", "PhotoFullImageId", "dbo.Aircraft");
            DropIndex("dbo.AirlineAircrafts", new[] { "Aircraft_AircraftID" });
            DropIndex("dbo.AirlineAircrafts", new[] { "Airline_AirlineId" });
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropIndex("dbo.PhotoFullImages", new[] { "PhotoFullImageId" });
            DropTable("dbo.AirlineAircrafts");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
            DropTable("dbo.Airlines");
            DropTable("dbo.PhotoFullImages");
            DropTable("dbo.Aircraft");
        }
    }
}
