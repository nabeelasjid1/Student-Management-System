using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RanaSchool.web.ViewModels
{
    public class HomeViewModels
    {
        public List<Notice> Notice { get; set; }
        public List<Event> Event { get; set; }
    }
}