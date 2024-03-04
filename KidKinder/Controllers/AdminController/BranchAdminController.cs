using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class BranchAdminController : Controller
    {
        // GET: BranchAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult BranchList()
        {
            var values = kidKinderContext.Branches.ToList();
            return View(values);
        }
    }
}