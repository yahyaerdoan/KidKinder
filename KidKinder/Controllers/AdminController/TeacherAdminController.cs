using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
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

        [HttpGet]
        public ActionResult CreateTeacher()
        {
            GetBranchListBySelectListItem();
            return View();
        }
        [HttpPost]
        public ActionResult CreateTeacher(Teacher teacher)
        {
            kidKinderContext.Teachers.Add(teacher);
            kidKinderContext.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        public ActionResult DeleteTeacher(int id)
        {
            var value = kidKinderContext.Teachers.Find(id);
            kidKinderContext.Teachers.Remove(value);
            kidKinderContext.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        [HttpGet]
        public ActionResult UpdateTeacher(int id)
        {
            GetBranchListBySelectListItem();
            var value = kidKinderContext.Teachers.Find(id);
            return View(value);
        }
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult UpdateTeacher(Teacher teacher)
        {
            var value = kidKinderContext.Teachers.Find(teacher.TeacherId);
            value.Name = teacher.Name;
            value.Surname = teacher.Surname;
            value.BranchId = teacher.BranchId;
            value.FieldOfStudy = teacher.FieldOfStudy;
            value.Image = teacher.Image;
            kidKinderContext.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        public void GetBranchListBySelectList()
        {
            ViewBag.BranchName = new SelectList(kidKinderContext.Branches.ToList(), "BranchId", "Name");
        }

        public void GetBranchListBySelectListItem()
        {
            List<SelectListItem> values = (from item in kidKinderContext.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = item.Name,
                                               Value = item.BranchId.ToString()
                                           }).ToList();
            ViewBag.BranchName = values;
        }
    }   
}