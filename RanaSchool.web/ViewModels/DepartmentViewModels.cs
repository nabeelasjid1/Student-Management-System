using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RanaSchool.web.ViewModels
{
    public class NewDepartmentViewModels
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string CreditHours { get; set; }
        public string MaximumCapacity { get; set; }
        public string ImageURL { get; set; }
        public int DepartmentID { get; set; }
    }
}