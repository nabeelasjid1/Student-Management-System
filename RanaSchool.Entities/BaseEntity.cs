using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Contact { get; set; }
        public string Cnic { get; set; }
        public string Email { get; set; }


    }
}
