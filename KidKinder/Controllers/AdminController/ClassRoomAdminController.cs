using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class ClassRoomAdminController : Controller
    {
        // GET: ClassRoom
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult ClassRoomList()
        {
            var values = kidKinderContext.ClassRooms.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateClassRoom()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult CreateClassRoom(ClassRoom classRoom)
        {
            kidKinderContext.ClassRooms.Add(classRoom);
            kidKinderContext.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }
        public ActionResult DeleteClassRoom(int id)
        {
            var values = kidKinderContext.ClassRooms.Find(id);
            kidKinderContext.ClassRooms.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("ClassRoomList");
        }
    }    
}