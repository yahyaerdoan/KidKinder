using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class FeatureAdminController : Controller
    {
        // GET: FeatureAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult FeatureList()
        {
            var values = kidKinderContext.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFeature(Feature feature)
        {
            kidKinderContext.Features.Add(feature);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteFeature(int id)
        {
            var values = kidKinderContext.Features.Find(id);
            kidKinderContext.Features.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}