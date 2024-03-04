using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class AboutListAdminController : Controller
    {
        // GET: AboutListAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult AboutList()
        {
            var values = kidKinderContext.AboutLists.ToList();
            return View(values);
        }
    }
}