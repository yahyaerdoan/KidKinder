using KidKinder.Context;
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
        public ActionResult BookASeatList()
        {
            //ViewBag.ClassRoomHeaderName = new SelectList(kidKinderContext.ClassRooms.ToList());
            //GetClassHeadertBySelectListItem();
            new SelectList(kidKinderContext.ClassRooms.ToList());
            var values = kidKinderContext.BookASeats.ToList();
            return View(values);
        }

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
    }
}