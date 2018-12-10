using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RanaSchool.Service
{
    public class SubjectsService
    {
        public List<Subject> GetSubjects()
        {
            using (var context = new RSContext())
            {
                return context.Subjects.Include(x=> x.Department).ToList();
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
                context.Entry(subject.Department).State = System.Data.Entity.EntityState.Unchanged;

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
                var subject = context.Subjects.Find(ID);
                context.Subjects.Remove(subject);
                context.SaveChanges();
            }
        }
        public void AddStudent(Student student)
        {
            using (var context = new RSContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
