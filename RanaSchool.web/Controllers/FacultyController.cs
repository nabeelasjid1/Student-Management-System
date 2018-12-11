using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class FacultyController : Controller
    {

        TeachersService teacherService = new TeachersService();
        // GET: Faculty
        public ActionResult Index()
        {
            var teachers = teacherService.GetTeachers();
            return View(teachers);
        }
        public ActionResult FacultyDetails(int ID)
        {
            var teacher = teacherService.GetTeacher(ID);
            return View(teacher);
        }
    }
}