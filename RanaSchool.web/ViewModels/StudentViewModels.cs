using RanaSchool.Entities;
using RanaSchool.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RanaSchool.web.ViewModels
{
    public class StudentViewModels
    {
        public Student Student { get; set; }
        public RegisterViewModel User { get; set; }
        public List<Department> Departments { get; set; }
    }
}