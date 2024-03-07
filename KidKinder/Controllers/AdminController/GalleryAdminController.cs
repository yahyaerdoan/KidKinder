using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class GalleryAdminController : Controller
    {
        // GET: Gallery
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult GalleryList()
        {
            var values = kidKinderContext.Galleries.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateGallery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGallery(Gallery gallery)
        {
            kidKinderContext.Galleries.Add(gallery);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteGallery(int id)
        {
            var values = kidKinderContext.Galleries.Find(id);
            kidKinderContext.Galleries.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("GalleryList");
        }

        [HttpGet]
        public ActionResult UpdateGallery(int id)
        {
            var values = kidKinderContext.Galleries.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateGallery(Gallery gallery)
        {
            var values = kidKinderContext.Galleries.Find(gallery.GalleryId);
            values.CategoryId = gallery.CategoryId;
            values.Description = gallery.Description;
            values.Image1 = gallery.Image1;
            values.Image2 = gallery.Image2;
            values.Statu = gallery.Statu = false;            
            kidKinderContext.SaveChanges();
            return RedirectToAction("GalleryList");
        }
    }
}