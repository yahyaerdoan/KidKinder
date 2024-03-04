using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.DefaultViewController
{
    public class AboutController : Controller
    {
        // GET: About
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutListPartial()
        {
            return PartialView(kidKinderContext.AboutLists.ToList());
        }
    }
}