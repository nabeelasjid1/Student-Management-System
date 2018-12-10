namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoticeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Admin_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.Admin_ID)
                .Index(t => t.Admin_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notices", "Admin_ID", "dbo.Admins");
            DropIndex("dbo.Notices", new[] { "Admin_ID" });
            DropTable("dbo.Notices");
        }
    }
}
