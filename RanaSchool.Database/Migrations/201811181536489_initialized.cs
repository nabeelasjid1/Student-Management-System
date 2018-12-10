namespace RanaSchool.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Admin_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.Admin_ID)
                .Index(t => t.Admin_ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegNumber = c.String(),
                        Name = c.String(),
                        Contact = c.String(),
                        Cnic = c.String(),
                        Email = c.String(),
                        Parent_ID = c.Int(),
                        Teacher_ID = c.Int(),
                        Subject_ID = c.Int(),
                        Parent_ID1 = c.Int(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Parents", t => t.Parent_ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .ForeignKey("dbo.Subjects", t => t.Subject_ID)
                .ForeignKey("dbo.Parents", t => t.Parent_ID1)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Parent_ID)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Subject_ID)
                .Index(t => t.Parent_ID1)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Cnic = c.String(),
                        Email = c.String(),
                        Student_ID = c.Int(),
                        Teacher_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .Index(t => t.Student_ID)
                .Index(t => t.Teacher_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Cnic = c.String(),
                        Email = c.String(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Department_ID = c.Int(),
                        Student_ID = c.Int(),
                        Teacher_ID = c.Int(),
                        Student_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .ForeignKey("dbo.Students", t => t.Student_ID1)
                .Index(t => t.Department_ID)
                .Index(t => t.Student_ID)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Student_ID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Subjects", "Student_ID1", "dbo.Students");
            DropForeignKey("dbo.Students", "Parent_ID1", "dbo.Parents");
            DropForeignKey("dbo.Subjects", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Subject_ID", "dbo.Subjects");
            DropForeignKey("dbo.Subjects", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Subjects", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Students", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Parents", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Students", "Parent_ID", "dbo.Parents");
            DropForeignKey("dbo.Parents", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Departments", "Admin_ID", "dbo.Admins");
            DropIndex("dbo.Subjects", new[] { "Student_ID1" });
            DropIndex("dbo.Subjects", new[] { "Teacher_ID" });
            DropIndex("dbo.Subjects", new[] { "Student_ID" });
            DropIndex("dbo.Subjects", new[] { "Department_ID" });
            DropIndex("dbo.Teachers", new[] { "Department_ID" });
            DropIndex("dbo.Parents", new[] { "Teacher_ID" });
            DropIndex("dbo.Parents", new[] { "Student_ID" });
            DropIndex("dbo.Students", new[] { "Department_ID" });
            DropIndex("dbo.Students", new[] { "Parent_ID1" });
            DropIndex("dbo.Students", new[] { "Subject_ID" });
            DropIndex("dbo.Students", new[] { "Teacher_ID" });
            DropIndex("dbo.Students", new[] { "Parent_ID" });
            DropIndex("dbo.Departments", new[] { "Admin_ID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Teachers");
            DropTable("dbo.Parents");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
            DropTable("dbo.Admins");
        }
    }
}
