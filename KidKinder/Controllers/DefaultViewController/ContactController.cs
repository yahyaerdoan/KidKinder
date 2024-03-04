using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.DefaultViewController
{
    public class ContactController : Controller
    {
        // GET: Contact
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {   
            var value = kidKinderContext.Contacts.Add(contact);
            value.IsRead = false;
            value.SendDate = DateTime.Now;
            kidKinderContext.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}