using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KidKinder.Controllers.AdminController
{
    public class LogOutController : Controller
    {
        // GET: LogOut
        public ActionResult LogOutFrom()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AdminLogIn", "LogIn");
        }
    }
}