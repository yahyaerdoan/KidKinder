using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class ClassRoomAdminController : Controller
    {
        // GET: ClassRoom
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult ClassRoomList()
        {
            var values = kidKinderContext.ClassRooms.ToList();
            return View(values);
        }
    }    
}