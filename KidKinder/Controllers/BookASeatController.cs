using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class BookASeatController : Controller
    {
        // GET: BookASeat
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult BookASeatPartial()
        {       
            return PartialView();
        } 
        
        [HttpPost]
        public ActionResult AddBookNow(BookASeat bookASeat)
        {
            kidKinderContext.BookASeats.Add(bookASeat);
            kidKinderContext.SaveChanges();            
            return RedirectToAction("Index", "Default");
        }
    }
}