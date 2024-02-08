using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavigationBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }

        public PartialViewResult ServicePartial()
        {
            return PartialView();
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public PartialViewResult ClassRoomPartial()
        {
            return PartialView();
        }

        public PartialViewResult BookASeatPartial()
        {
            return PartialView();
        }

        public PartialViewResult TeacherPartial()
        {
            return PartialView();
        }
      
        public PartialViewResult TestimonialPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}