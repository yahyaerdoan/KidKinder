using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class BookASeatController : Controller
    {
        // GET: BookASeat
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BookASeatPartial()
        {
            return PartialView();
        }
    }
}