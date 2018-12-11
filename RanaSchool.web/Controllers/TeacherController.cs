using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class TeacherController : Controller
    {
        TeachersService teacherService = new TeachersService();
        // GET: Teacher
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TeacherTable()
        {
            var teacher = teacherService.GetTeachers();
            return PartialView(teacher);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
            
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            teacherService.SaveTeacher(teacher);
            return RedirectToAction("TeacherTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var teacher = teacherService.GetTeacher(ID);
            return PartialView(teacher);
        }
        [HttpPost]
        public ActionResult Edit(Teacher teacher)
        {
            teacherService.UpdateTeacher(teacher);
            return RedirectToAction("TeacherTable");
        }
        [HttpPost]
        public ActionResult Delete(Teacher teacher)
        {
            teacherService.DeleteTeacher(teacher.ID);
            return RedirectToAction("TeacherTable");
        }
    }
}