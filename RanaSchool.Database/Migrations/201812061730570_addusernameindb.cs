namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusernameindb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parents", "UserName", c => c.String());
            AddColumn("dbo.Parents", "Password", c => c.String());
            AddColumn("dbo.Parents", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Teachers", "UserName", c => c.String());
            AddColumn("dbo.Teachers", "Password", c => c.String());
            AddColumn("dbo.Teachers", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "ConfirmPassword");
            DropColumn("dbo.Teachers", "Password");
            DropColumn("dbo.Teachers", "UserName");
            DropColumn("dbo.Parents", "ConfirmPassword");
            DropColumn("dbo.Parents", "Password");
            DropColumn("dbo.Parents", "UserName");
        }
    }
}
