using KidKinder.Context;
using KidKinder.Entities;
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

        [HttpGet]
        public ActionResult CreateBranch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBranch(Branch branch)
        {
            kidKinderContext.Branches.Add(branch);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteBranch(int id)
        {
            var values = kidKinderContext.Branches.Find(id);
            kidKinderContext.Branches.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public ActionResult UpdateBranch(int id)
        {
            var values = kidKinderContext.Branches.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateBranch(Branch branch)
        {
            var values = kidKinderContext.Branches.Find(branch.BranchId);
            values.Name = branch.Name;          
            kidKinderContext.SaveChanges();
            return RedirectToAction("BranchList");
        }
    }
}