using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string CreditHours { get; set; }
        public string MaximumCapacity { get; set; }
        public string ImageURL { get; set; }
        public Department Department { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public List<Student> Students { get; set; }

    }
}
