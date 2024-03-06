using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class AboutListAdminController : Controller
    {
        // GET: AboutListAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult AboutList()
        {
            var values = kidKinderContext.AboutLists.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAboutList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAboutList(AboutList aboutList)
        {
            kidKinderContext.AboutLists.Add(aboutList);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteAboutList(int id)
        {
            var values = kidKinderContext.AboutLists.Find(id);
            kidKinderContext.AboutLists.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAboutList(int id)
        {
            var values = kidKinderContext.AboutLists.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAboutList(AboutList aboutList)
        {
            var values = kidKinderContext.AboutLists.Find(aboutList.AboutListId);           
            values.Description = aboutList.Description;
            kidKinderContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}