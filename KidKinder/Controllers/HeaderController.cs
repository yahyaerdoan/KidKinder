using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult Index()
        {
            ViewData["Title"] = "Yahya";
            return View();
        }
        
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
    }
}