using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KidKinder.Controllers.AdminController
{
    public class LogInController : Controller
    {
        // GET: Login
        KidKinderContext kidKinderContext = new KidKinderContext();
       
        [HttpGet]
        public ActionResult AdminLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogIn(Admin admin)
        {
            var result = kidKinderContext.Admins.FirstOrDefault(a => a.UserName == admin.UserName && a.Password == admin.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.UserName, true);
                Session["UserName"] = result.UserName;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }           
        }       
    }
}