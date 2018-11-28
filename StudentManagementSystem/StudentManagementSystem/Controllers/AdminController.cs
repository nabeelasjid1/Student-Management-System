using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementSystem.Models;
using StudentManagementSystem.CollectionViewModel;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db;
        // GET: Admin
        public ActionResult Index()
        {
            var model = new CourseCollection
            {
                Courses = new Course(),
                Users = db.Users.ToList()
            };
            return View(model);
        }

        //Course Section 
        [Authorize]
        public ActionResult AddCourse()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCourse(Course model)
        {
            return View();
        }
    }
}