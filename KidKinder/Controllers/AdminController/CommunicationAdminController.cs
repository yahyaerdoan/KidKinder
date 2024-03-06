using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class CommunicationAdminController : Controller
    {
        // GET: Communication
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult CommunicationList()
        {
            var values = kidKinderContext.Communications.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCommunication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCommunication(Communication communication)
        {
            kidKinderContext.Communications.Add(communication);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteCommunication(int id)
        {
            var values = kidKinderContext.Communications.Find(id);
            kidKinderContext.Communications.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("CommunicationList");
        }

        [HttpGet]
        public ActionResult UpdateCommunication(int id)
        {
            var values = kidKinderContext.Communications.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCommunication(Communication communication)
        {
            var values = kidKinderContext.Communications.Find(communication.CommunicationId);
            values.Title = communication.Title;
            values.Header = communication.Header;
            values.Descripction = communication.Descripction;
            values.Address = communication.Address;
            values.Email = communication.Email;
            values.Phone = communication.Phone;
            values.OpeningHour = communication.OpeningHour;
            values.Day = communication.Day;
            values.Hour = communication.Hour;
            kidKinderContext.SaveChanges();
            return RedirectToAction("CommunicationList");
        }
    }
}