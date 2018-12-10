using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public List<Notice> Notices { get; set; }
        public List<Event> Events { get; set; }
    }
}
