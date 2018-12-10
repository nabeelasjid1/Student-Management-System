using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Admin Admin { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
    }
}
