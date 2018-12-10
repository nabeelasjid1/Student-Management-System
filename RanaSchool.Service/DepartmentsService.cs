using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class DepartmentsService
    {
        public List<Department> GetDepartments()
        {
            using (var context = new RSContext())
            {
                return context.Departments.ToList();
            }
        }


        public Department GetDepartment(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Departments.Find(ID);
            }
        }

        public void SaveDepartment(Department department)
        {
            using (var context = new RSContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }
        public void UpdateDepartment(Department department)
        {
            using (var context = new RSContext())
            {
                context.Entry(department).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteDepartment(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var department = context.Departments.Find(ID);
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }
    }
}
