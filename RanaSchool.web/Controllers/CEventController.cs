using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class CEventController : Controller
    {
        EventsService eventsService = new EventsService();
        // GET: CEvent
        public ActionResult Index()
        {
            var vent = eventsService.GetEvents();
            return View(vent);
        }
        public ActionResult EventDetials(int ID)
        {
            var vent = eventsService.GetEvent(ID);
            return View(vent);
        }
    }
}