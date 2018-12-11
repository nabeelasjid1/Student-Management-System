using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class StudentController : Controller
    {
        StudentsService studentsService = new StudentsService();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentTable(string search)
        {
            var students = studentsService.GetStudents();
            if (!string.IsNullOrEmpty(search))
            {
                students = students.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            studentsService.SaveStudent(student);
            return RedirectToAction("StudentTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var student = studentsService.GetStudent(ID);
            return PartialView(student);

        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            studentsService.UpdateStudent(student);
            return RedirectToAction("StudentTable");
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            studentsService.DeleteStudent(ID);
            return RedirectToAction("StudentTable");
        }
    }
}