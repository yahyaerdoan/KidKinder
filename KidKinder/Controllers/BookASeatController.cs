using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class BookASeatController : Controller
    {
        // GET: BookASeat
        KidKinderContext kinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BookASeatPartial()
        {
            //ViewBag.ClassRoomHeader = new SelectList(kinderContext.ClassRooms.ToList(), "ClassRoomId", "Header");
            return PartialView();
        }
    }
}