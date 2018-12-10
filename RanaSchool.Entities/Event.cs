using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class Event
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public Admin Admin { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teacher { get; set; }
    }
}
