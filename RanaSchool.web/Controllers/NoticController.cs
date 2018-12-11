using RanaSchool.Entities;
using RanaSchool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanaSchool.web.Controllers
{
    public class NoticController : Controller
    {
        NoticesService noticesService = new NoticesService();
        // GET: Notic
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NoticeTable()
        {
            var notices = noticesService.GetNotices();
            return PartialView(notices);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return  PartialView();
        }
        [HttpPost]
        public ActionResult Create(Notice notice)
        {
            noticesService.SaveNotice(notice);
            return RedirectToAction("NoticeTable");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var teacher = noticesService.GetNotice(ID);
            return PartialView(teacher);
        }
        [HttpPost]
        public ActionResult Edit(Notice notice)
        {
            noticesService.UpdateNotice(notice);
            return RedirectToAction("NoticeTable");
        }

        [HttpPost]
        public ActionResult Delete(Notice notice)
        {
            noticesService.DeleteNotice(notice.ID);
            return RedirectToAction("NoticeTable");
        }
    }
}