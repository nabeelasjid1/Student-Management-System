namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTeacherPropertiesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Faculty", c => c.String());
            AddColumn("dbo.Teachers", "Hobies", c => c.String());
            AddColumn("dbo.Teachers", "Experience", c => c.String());
            AddColumn("dbo.Teachers", "Degree", c => c.String());
            AddColumn("dbo.Teachers", "About", c => c.String());
            AddColumn("dbo.Teachers", "Designation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Designation");
            DropColumn("dbo.Teachers", "About");
            DropColumn("dbo.Teachers", "Degree");
            DropColumn("dbo.Teachers", "Experience");
            DropColumn("dbo.Teachers", "Hobies");
            DropColumn("dbo.Teachers", "Faculty");
        }
    }
}
