using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Student : BaseEntity
    {
        public Teacher Teacher { get; set; }
        public Parent Parent { get; set; }
        public List<Subject> Subjects { get; set; }
        public string RegNumber { get; set; }
    }
}
