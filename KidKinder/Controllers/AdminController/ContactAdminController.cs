using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ContactAdminController : Controller
    {
        // GET: ContactAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult ContactList()
        {
            var values = kidKinderContext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            contact.IsRead = false;
            kidKinderContext.Contacts.Add(contact);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteContact(int id)
        {
            var values = kidKinderContext.Contacts.Find(id);
            kidKinderContext.Contacts.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}