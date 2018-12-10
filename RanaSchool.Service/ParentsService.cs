using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class ParentsService
    {
        public List<Parent> GetParents()
        {
            using (var context = new RSContext())
            {
                return context.Parents.ToList();
            }
        }


        public Parent GetParent(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Parents.Find(ID);
            }
        }

        public void SaveParent(Parent parent)
        {
            using (var context = new RSContext())
            {
                context.Parents.Add(parent);
                context.SaveChanges();
            }
        }
        public void UpdateParent(Parent parent)
        {
            using (var context = new RSContext())
            {
                context.Entry(parent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteParent(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var parent = context.Parents.Find(ID);
                context.Parents.Remove(parent);
                context.SaveChanges();
            }
        }
    }
}
