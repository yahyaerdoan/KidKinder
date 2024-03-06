using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class NotificationAdminController : Controller
    {
        // GET: NotificationAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult NotificationList()
        {
            var values = kidKinderContext.Notifications.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateNotification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNotification(Notification notification)
        {
            notification.Time = DateTime.Now;
            kidKinderContext.Notifications.Add(notification);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteNotification(int id)
        {
            var values = kidKinderContext.Notifications.Find(id);
            kidKinderContext.Notifications.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("NotificationList");
        }

        [HttpGet]
        public ActionResult UpdateNotification(int id)
        {
            var values = kidKinderContext.Notifications.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateNotification(Notification notification)
        {
            var values = kidKinderContext.Notifications.Find(notification.NotificationId);
            values.Title = notification.Title;           
            values.Image = notification.Image;
            values.Description = notification.Description;
            values.Time = notification.Time = DateTime.Now;
            kidKinderContext.SaveChanges();
            return RedirectToAction("NotificationList");
        }
    }
}