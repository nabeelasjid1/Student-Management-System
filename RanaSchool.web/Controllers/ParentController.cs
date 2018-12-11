using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class ParentController : Controller
    {
        ParentsService parentsService = new ParentsService();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ParentTable()
        {
            var parents = parentsService.GetParents();
            return PartialView(parents);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(Parent parent)
        {
            parentsService.SaveParent(parent);
            return RedirectToAction("ParentTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var parent = parentsService.GetParent(ID);
            return PartialView(parent);

        }
        [HttpPost]
        public ActionResult Edit(Parent parent)
        {
            parentsService.UpdateParent(parent);
            return RedirectToAction("ParentTable");
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            parentsService.DeleteParent(ID);
            return RedirectToAction("ParentTable");
        }
    }
}