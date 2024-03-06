using KidKinder.Context;
using KidKinder.Entities;
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

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {           
            kidKinderContext.Testimonials.Add(testimonial);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = kidKinderContext.Testimonials.Find(id);
            kidKinderContext.Testimonials.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = kidKinderContext.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var values = kidKinderContext.Testimonials.Find(testimonial.TestimonialId);
            values.Title = testimonial.Title;
            values.Name = testimonial.Name;
            values.Surname = testimonial.Surname;
            values.Comment = testimonial.Comment;
            values.Image = testimonial.Image;
            kidKinderContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}