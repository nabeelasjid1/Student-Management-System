namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subjectAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "ImageURL", c => c.String());
            AddColumn("dbo.Subjects", "Description", c => c.String());
            AddColumn("dbo.Subjects", "About", c => c.String());
            AddColumn("dbo.Subjects", "Name", c => c.String());
            AddColumn("dbo.Subjects", "CreditHours", c => c.String());
            AddColumn("dbo.Subjects", "MaximumCapacity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "MaximumCapacity");
            DropColumn("dbo.Subjects", "CreditHours");
            DropColumn("dbo.Subjects", "Name");
            DropColumn("dbo.Subjects", "About");
            DropColumn("dbo.Subjects", "Description");
            DropColumn("dbo.Subjects", "ImageURL");
        }
    }
}
