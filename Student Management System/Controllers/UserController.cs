﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult AdminPanel()
        {
            return View();

        }
        public ActionResult StudentPanel()
        {
            return View();

        }
        public ActionResult ParentPanel()
        {
            return View();

        }
        public ActionResult TeacherPanel()
        {
            return View();

        }
    }
}