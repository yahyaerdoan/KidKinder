using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class CommunicationController : Controller
    {
        // GET: Communication
        KidKinderContext kidKinderContex = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommunicationPartial()
        {
            ViewBag.description = kidKinderContex.Communications.Select(d => d.Descripction).FirstOrDefault();
            ViewBag.address = kidKinderContex.Communications.Select(a => a.Address).FirstOrDefault();
            ViewBag.email = kidKinderContex.Communications.Select(e => e.Email).FirstOrDefault();
            ViewBag.phone = kidKinderContex.Communications.Select(p => p.Phone).FirstOrDefault();
            ViewBag.day = kidKinderContex.Communications.Select(d => d.Day).FirstOrDefault();
            ViewBag.hour = kidKinderContex.Communications.Select(h => h.Hour).FirstOrDefault();
            return PartialView();
        }
    }
}