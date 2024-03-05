using KidKinder.Context;
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
    }
}