namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "UserName", c => c.String());
            AddColumn("dbo.Students", "Password", c => c.String());
            AddColumn("dbo.Students", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ConfirmPassword");
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "UserName");
        }
    }
}
