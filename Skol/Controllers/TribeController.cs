using Skol.Models;
using Skol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skol.Controllers
{
    public class TribeController : Controller
    {
        // GET: Tribe
        public ActionResult Index()
        {
            return View();
        }

        // GEt: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TribeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateTribeService();

            if(service.CreateTribe(model))
            {
                TempData["SaveResult"] = "Tribe Created!";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Tribe NOT created!");
            return View(model);
        }

        // CreateTribe Service
        private TribeService CreateTribeService()
        {
            var service = new TribeService();
            return service;
        }
    }
}