namespace AirPlane.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aircraft", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Aircraft", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Aircraft", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Aircraft", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aircraft", "Category", c => c.String());
            AlterColumn("dbo.Aircraft", "Description", c => c.String());
            AlterColumn("dbo.Aircraft", "Type", c => c.String());
            AlterColumn("dbo.Aircraft", "Name", c => c.String());
        }
    }
}
