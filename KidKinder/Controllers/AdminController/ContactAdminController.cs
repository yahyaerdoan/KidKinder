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

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = kidKinderContext.Contacts.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var values = kidKinderContext.Contacts.Find(contact.ContactId);
            values.Title = contact.Title;
            values.Header = contact.Header;
            values.Description = contact.Description;
            values.Name = contact.Name;
            values.Surname = contact.Surname;
            values.Email = contact.Email;
            values.Subject = contact.Subject;
            values.Message = contact.Message;
            values.SendDate = contact.SendDate = DateTime.Now;
            values.IsRead = contact.IsRead = false;
            kidKinderContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}