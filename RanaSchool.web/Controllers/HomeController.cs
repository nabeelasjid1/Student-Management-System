using RanaSchool.Service;
using RanaSchool.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class HomeController : Controller
    {
        NoticesService noticeServices = new NoticesService();
        EventsService eventsService = new EventsService();
        public ActionResult Index()
        {
            HomeViewModels model = new HomeViewModels();
            model.Notice = noticeServices.GetNotices();
            model.Event = eventsService.GetEvents();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}