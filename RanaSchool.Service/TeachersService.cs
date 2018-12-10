using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class TeachersService
    {
        public List<Teacher> GetTeachers()
        {
            using (var context = new RSContext())
            {
                return context.Teachers.ToList();
            }
        }


        public Teacher GetTeacher(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Teachers.Find(ID);
            }
        }

        public void SaveTeacher(Teacher teacher)
        {
            using (var context = new RSContext())
            {
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }
        public void UpdateTeacher(Teacher teacher)
        {
            using (var context = new RSContext())
            {
                context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteTeacher(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var teacher = context.Teachers.Find(ID);
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
        }
    }
}
