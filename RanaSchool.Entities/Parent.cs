using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Parent : BaseEntity
    {
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}
