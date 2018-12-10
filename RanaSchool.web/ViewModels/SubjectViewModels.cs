using RanaSchool.Entities;
using RanaSchool.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RanaSchool.web.ViewModels
{
    public class SubjectRegisterViewModels
    {
        public List<Student> Students { get; set; }
        public List<int> StudentIDs { get; set; }
        public ApplicationUser Users { get; set; }
    }
}