using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Database
{
    public class RSContext : DbContext, IDisposable
    {
        public RSContext() : base("RanaSchoolConnection")
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
