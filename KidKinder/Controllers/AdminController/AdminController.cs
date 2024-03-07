using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class AdminController : Controller
    {
        // GET: Admin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult AdminList()
        {
            var values = kidKinderContext.Admins.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdmin(Admin admin)
        {
            kidKinderContext.Admins.Add(admin);
            kidKinderContext.SaveChanges();
            return RedirectToAction("AdminList");
        }

        public ActionResult DeleteAdmin(int id)
        {
            var values = kidKinderContext.Admins.Find(id);
            kidKinderContext.Admins.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("AdminList");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var values = kidKinderContext.Admins.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Admin admin)
        {
            var values = kidKinderContext.Admins.Find(admin.AdminId);
            values.UserName = admin.UserName;
            values.Password = admin.Password;
            kidKinderContext.SaveChanges();
            return RedirectToAction("AdminList");
        }
    }
}