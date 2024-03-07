using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.BrachCount = kidKinderContext.Teachers.Where(x => x.BranchId == kidKinderContext.Branches.Where(z => z.Name == "Asp.Net").Select(y => y.BranchId).FirstOrDefault()).Count();

            ViewBag.AveragaPrice = kidKinderContext.ClassRooms.Average(z => z.Price).ToString("0.00");

            ViewBag.TeacherCount = kidKinderContext.Teachers.Count();
            return View();
        }

        public PartialViewResult ClassRoomTeacherChart()
        {
            var values = Json(ClassRoomsAndTeachers(), JsonRequestBehavior.AllowGet);           
            return PartialView(values);
        }
        public List<Teacher> ClassRoomsAndTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            var values = kidKinderContext.Teachers.ToList();
            foreach (var item in values)
            {
                var teacherData = new Teacher()
                {
                   Name = item.Name,
                   FieldOfStudy = item.FieldOfStudy
                };
                teachers.Add(teacherData);
            }           
             return values;            
        }
    }
}