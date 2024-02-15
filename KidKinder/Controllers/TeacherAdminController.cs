using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TeacherAdminController : Controller
    {
        // GET: TeacherAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult TeacherList()
        {
            var values = kidKinderContext.Teachers.ToList();
            return View(values);
        }
    }
}