using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class EventController : Controller
    {
        EventsService eventsService = new EventsService();
        // GET: Teacher
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EventTable()
        {
            var vents = eventsService.GetEvents();
            return PartialView(vents);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create(Event vent)
        {
            eventsService.SaveEvent(vent);
            return RedirectToAction("EventTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var vent = eventsService.GetEvent(ID);
            return PartialView(vent);
        }
        [HttpPost]
        public ActionResult Edit(Event vent)
        {
            eventsService.UpdateEvent(vent);
            return RedirectToAction("EventTable");
        }
        [HttpPost]
        public ActionResult Delete(Event vent)
        {
            eventsService.DeleteEvent(vent.ID);
            return RedirectToAction("EventTable");
        }
    }
}