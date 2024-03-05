using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class BookASeatAdminController : Controller
    {
        // GET: BookASeatAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        #region GetClassHeader
        public void GetClassHeadertBySelectListItem()
        {
            List<SelectListItem> values = (from item in kidKinderContext.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = item.Header,
                                               Value = item.ClassRoomId.ToString()
                                           }).ToList();
            ViewBag.ClassRoomHeader = values;
        }
        #endregion
        public ActionResult BookASeatList()
        {
            //ViewBag.ClassRoomHeaderName = new SelectList(kidKinderContext.ClassRooms.ToList());
            //GetClassHeadertBySelectListItem();
            new SelectList(kidKinderContext.ClassRooms.ToList());
            var values = kidKinderContext.BookASeats.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateBookASeat()
        {
            GetClassHeadertBySelectListItem();
            return View();
        }

        [HttpPost]
        public ActionResult CreateBookASeat(BookASeat bookASeat)
        {
            kidKinderContext.BookASeats.Add(bookASeat);
            kidKinderContext.SaveChanges();
            return RedirectToAction("BookASeatList");
        }
        public ActionResult DeleteBookASeat(int id)
        {
            var values = kidKinderContext.BookASeats.Find(id);
            kidKinderContext.BookASeats.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("BookASeatList");
        }
    }
}