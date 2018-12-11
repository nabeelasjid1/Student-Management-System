using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class StudentsService
    {
        public List<Student> GetStudents()
        {
            using (var context = new RSContext())
            {
                return context.Students.ToList();
            }
        }


        public Student GetStudent(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Students.Find(ID);
            }
        }

        public void SaveStudent(Student student)
        {
            using (var context = new RSContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        public void UpdateStudent(Student student)
        {
            using (var context = new RSContext())
            {
                context.Entry(student).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteStudent(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var student = context.Students.Find(ID);
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
