using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Teacher : BaseEntity
    {
        public string ImageURL { get; set; }
        public string Faculty { get; set; }
        public string Hobies { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string About { get; set; }
        public string Designation { get; set; }
        public Department Department { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }

    }
}
