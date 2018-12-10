using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class EventsService
    {
        public List<Event> GetEvents()
        {
            using (var context = new RSContext())
            {
                return context.Events.ToList();
            }
        }


        public Event GetEvent(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Events.Find(ID);
            }
        }

        public void SaveEvent(Event vent)
        {
            using (var context = new RSContext())
            {
                context.Events.Add(vent);
                context.SaveChanges();
            }
        }
        public void UpdateEvent(Event vent)
        {
            using (var context = new RSContext())
            {
                context.Entry(vent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteEvent(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var vent = context.Events.Find(ID);
                context.Events.Remove(vent);
                context.SaveChanges();
            }
        }
    }
}
