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

            ViewBag.TotalContact = kidKinderContext.Contacts.Count();

            ViewBag.TotalService = kidKinderContext.Services.Count();

            ViewBag.TotalClasses = kidKinderContext.ClassRooms.Count();

            ViewBag.TotalBookASeat = kidKinderContext.BookASeats.Count();

            ViewBag.TotalTestimonial = kidKinderContext.Testimonials.Count();

           var TeacherOfThisMonthNameSurname = kidKinderContext.Teachers
                .Where(teacher => teacher.TeacherId == 8)
                .Select(teacher =>
                new
                {
                    TeacherName = teacher.Name,
                    TeacherSurname = teacher.Surname
                });
            foreach (var item in TeacherOfThisMonthNameSurname)
            {
                ViewBag.TeacherOfThisMonthNameSurname = item.TeacherName + ' ' + item.TeacherSurname;
            };          

            ViewBag.MorePopularBranches = kidKinderContext.Branches.Where(b=> b.BranchId ==1).Select(b=> b.Name).FirstOrDefault();


            return View();
        }

        public PartialViewResult TeacherListPartial()
        {
            var values = kidKinderContext.Teachers.ToList();
            return PartialView(values);
        }

        public PartialViewResult ClassRoomTeacherChart()
        {
            ViewBag.TotalTeachers = kidKinderContext.Teachers.Count();
            ViewBag.TotalClasses = kidKinderContext.ClassRooms.Count();
            ViewBag.TotalBranches = kidKinderContext.Branches.Count();
            ViewBag.TotalServices = kidKinderContext.Services.Count();
            ViewBag.TotalGalleries = kidKinderContext.Galleries.Count();

            //not working
            var values = Json(ClassRoomsAndTeachers(), JsonRequestBehavior.AllowGet);           
            return PartialView(values);
        }
        public List<Teacher> ClassRoomsAndTeachers()
        {
            //not working
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