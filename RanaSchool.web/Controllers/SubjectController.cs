using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class SubjectController : Controller
    {
        SubjectsService subjectsService = new SubjectsService();
        // GET: Subject
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SubjectTable()
        {
            var subjects = subjectsService.GetSubjects();
            return PartialView(subjects);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            subjectsService.SaveSubject(subject);
            return RedirectToAction("SubjectTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var subject = subjectsService.GetSubject(ID);
            return PartialView(subject);
        }
        [HttpPost]
        public ActionResult Edit(Subject subject)
        {
            subjectsService.UpdateSubject(subject);
            return RedirectToAction("SubjectTable");
        }
        [HttpPost]
        public ActionResult Delete(Subject subject)
        {
            subjectsService.DeleteSubject(subject.ID);
            return RedirectToAction("SubjectTable");
        }
    }
}