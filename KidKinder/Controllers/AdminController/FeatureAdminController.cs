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

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var values = kidKinderContext.Features.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature feature)
        {
            var values = kidKinderContext.Features.Find(feature.FeatureId);
            values.Title = feature.Title;
            values.Header = feature.Header;
            values.Image = feature.Image;
            values.Description = feature.Description;           
            kidKinderContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}