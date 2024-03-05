using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class ServiceAdminController : Controller
    {
        // GET: ServiceAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult ServiceList()
        {
            var values = kidKinderContext.Services.ToList();
            return View(values);
        }
    }
}