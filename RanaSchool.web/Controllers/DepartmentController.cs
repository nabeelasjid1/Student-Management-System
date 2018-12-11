using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentsService departmentsService = new DepartmentsService();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DepartmentTable()
        {
            var departments = departmentsService.GetDepartments();
            return PartialView(departments);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            departmentsService.SaveDepartment(department);
            return RedirectToAction("DepartmentTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var department = departmentsService.GetDepartment(ID);
            return PartialView(department);

        }
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            departmentsService.UpdateDepartment(department);
            return RedirectToAction("DepartmentTable");
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            departmentsService.DeleteDepartment(ID);
            return RedirectToAction("DepartmentTable");
        }
    }
}