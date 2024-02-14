using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassRoomController : Controller
    {
        // GET: ClassRoom
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ClassRoomPartial()
        {
            return PartialView();
        }
    }
}