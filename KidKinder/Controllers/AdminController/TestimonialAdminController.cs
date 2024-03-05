using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class TestimonialAdminController : Controller
    {
        // GET: TestimonialAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult TestimonialList()
        {
            var values = kidKinderContext.Testimonials.ToList();
            return View(values);
        }
    }
}