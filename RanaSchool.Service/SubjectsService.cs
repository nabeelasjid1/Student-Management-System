using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class SubjectsService
    {
        public List<Subject> GetSubjects()
        {
            using (var context = new RSContext())
            {
                return context.Subjects.ToList();
            }
        }


        public Subject GetSubject(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Subjects.Find(ID);
            }
        }

        public void SaveSubject(Subject subject)
        {
            using (var context = new RSContext())
            {
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
        }
        public void UpdateSubject(Subject subject)
        {
            using (var context = new RSContext())
            {
                context.Entry(subject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteSubject(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var subject = context.Subjects.Find(ID);
                context.Subjects.Remove(subject);
                context.SaveChanges();
            }
        }
    }
}
