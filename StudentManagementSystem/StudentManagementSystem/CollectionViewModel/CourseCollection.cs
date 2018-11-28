using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.CollectionViewModel
{
    public class CourseCollection
    {
        public Course Courses { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}