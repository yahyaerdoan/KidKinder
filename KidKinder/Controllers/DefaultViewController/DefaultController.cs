 using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.DefaultViewController
{
    
    public class DefaultController : Controller
    {
        // GET: Default
        KidKinderContext kidKinderContext = new KidKinderContext();
        [AllowAnonymous]
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

        public PartialViewResult HeaderPartial()
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
            var values = kidKinderContext.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutDescriptionPartial()
        {
            ViewBag.title = kidKinderContext.Abouts.Select(t => t.Title).FirstOrDefault();
            ViewBag.description = kidKinderContext.Abouts.Select(d => d.Description).FirstOrDefault();           
            return PartialView();
        }
        
        public PartialViewResult AboutListPartial()
        {
            var values = kidKinderContext.AboutLists.ToList();
            return PartialView(values);
        }

        public PartialViewResult ClassRoomPartial()
        {
            var values = kidKinderContext.ClassRooms.OrderByDescending(i => i.ClassRoomId).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult BookASeatPartial()
        {
            ViewBag.ClassRoomHeader = new SelectList(kidKinderContext.ClassRooms.ToList(), "ClassRoomId", "Header");
            return PartialView();
        }

        public PartialViewResult TeacherPartial()
        {
            var values = kidKinderContext.Teachers.ToList();
            return PartialView(values);
        }
      
        public PartialViewResult TestimonialPartial()
        {
            var values = kidKinderContext.Testimonials.ToList();
            return PartialView(values);
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