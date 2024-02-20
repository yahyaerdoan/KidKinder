using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreLoaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavigatonBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult NotificationPartial()
        {
            var values = kidKinderContext.Notifications.ToList();
            return PartialView(values);
        }

        public PartialViewResult ProfilePartial()
        {
            return PartialView();
        }

        public PartialViewResult SideBarPartial()
        {
           return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
    }
}