using KidKinder.Context;
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
        KidKinderContext kidKinderContext = new KidKinderContext();
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
            var values = kidKinderContext.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial()
        {
            var values = kidKinderContext.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public PartialViewResult ClassRoomPartial()
        {
            var values = kidKinderContext.ClassRooms.ToList();
            return PartialView(values);
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