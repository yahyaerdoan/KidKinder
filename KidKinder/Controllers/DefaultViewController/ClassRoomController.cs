using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.DefaultViewController
{
    public class ClassRoomController : Controller
    {
        // GET: ClassRoom
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            var values = kidKinderContext.ClassRooms.ToList();
            return View(values);
        }

        public PartialViewResult ClassRoomPartial()
        {
            return PartialView();
        }
    }
}