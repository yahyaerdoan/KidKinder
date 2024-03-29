﻿using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers.AdminController
{
    public class ServiceAdminController : Controller
    {
        // GET: ServiceAdmin
        KidKinderContext kidKinderContext = new KidKinderContext();
        public ActionResult ServiceList()
        {
            var values = kidKinderContext.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            kidKinderContext.Services.Add(service);
            kidKinderContext.SaveChanges();
            return View();
        }
        public ActionResult DeleteService(int id)
        {
            var values = kidKinderContext.Services.Find(id);
            kidKinderContext.Services.Remove(values);
            kidKinderContext.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = kidKinderContext.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var values = kidKinderContext.Services.Find(service.ServiceId);
            values.Title = service.Title;          
            values.Description = service.Description;
            values.Icon = service.Icon;
            kidKinderContext.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}