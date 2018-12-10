namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Description = c.String(),
                        Admin_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.Admin_ID)
                .Index(t => t.Admin_ID);
            
            AddColumn("dbo.Students", "Event_ID", c => c.Int());
            AddColumn("dbo.Teachers", "Event_ID", c => c.Int());
            CreateIndex("dbo.Students", "Event_ID");
            CreateIndex("dbo.Teachers", "Event_ID");
            AddForeignKey("dbo.Students", "Event_ID", "dbo.Events", "ID");
            AddForeignKey("dbo.Teachers", "Event_ID", "dbo.Events", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Event_ID", "dbo.Events");
            DropForeignKey("dbo.Students", "Event_ID", "dbo.Events");
            DropForeignKey("dbo.Events", "Admin_ID", "dbo.Admins");
            DropIndex("dbo.Events", new[] { "Admin_ID" });
            DropIndex("dbo.Teachers", new[] { "Event_ID" });
            DropIndex("dbo.Students", new[] { "Event_ID" });
            DropColumn("dbo.Teachers", "Event_ID");
            DropColumn("dbo.Students", "Event_ID");
            DropTable("dbo.Events");
        }
    }
}
