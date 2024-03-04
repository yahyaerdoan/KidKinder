using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class CommunicationAdminController : Controller
    {
        // GET: Communication
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult CommunicationList()
        {
            var values = kidKinderContext.Communications.ToList();
            return View(values);
        }
    }
}