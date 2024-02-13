using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}