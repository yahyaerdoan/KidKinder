using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class FeatureAdminController : Controller
    {
        // GET: FeatureAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult FeatureList()
        {
            var values = kidKinderContext.Features.ToList();
            return View(values);
        }
    }
}