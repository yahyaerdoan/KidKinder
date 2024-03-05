using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class AboutAdminController : Controller
    {
        // GET: AboutAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult About()
        {
            var values = kidKinderContext.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            kidKinderContext.Abouts.Add(about);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = kidKinderContext.Abouts.Find(id);
            kidKinderContext.Abouts.Remove(values);           
            kidKinderContext.SaveChanges();
            return RedirectToAction("About");
        }
    }
}