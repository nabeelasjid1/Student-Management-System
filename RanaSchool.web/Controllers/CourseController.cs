using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class CourseController : Controller
    {
        SubjectsService subjectsService = new SubjectsService();
        // GET: Course
        public ActionResult Index()
        {
            var subjects = subjectsService.GetSubjects();
            return View(subjects);
        }
        public ActionResult SubjectDetails(int ID)
        {
            var subjects = subjectsService.GetSubject(ID);
            return View(subjects);
        }
    }
}