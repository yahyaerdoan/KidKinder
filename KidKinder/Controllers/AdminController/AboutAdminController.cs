using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class AboutAdminController : Controller
    {
        // GET: AboutAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            var values = kidKinderContext.Abouts.ToList();
            return View(values);
        }
    }
}