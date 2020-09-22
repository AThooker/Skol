using Skol.Models;
using Skol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skol.Controllers
{
    public class VikingController : Controller
    {
        // GET: Viking
        public ActionResult Index()
        {
            return View();
        }

        // Get: Create Viking
        public ActionResult Create()
        {
            return View();
        }

        // Post: Create Viking
        public ActionResult Create(VikingCreate model)
        {
            var service = new VikingService();
            var model = service.
        }
    }
}