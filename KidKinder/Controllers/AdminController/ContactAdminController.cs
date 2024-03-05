using KidKinder.Context;
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
    }
}