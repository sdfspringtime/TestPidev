using Pidev.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPidev.Controllers
{
    public class MissionRequestController : Controller
    {
        // GET: MissionRequest
        public ActionResult Index()
        {
            var coll = new expform() { amount = "22.00", description = "aaaaaaaaaa1", Justification = "just1" };

            return View();
        }
    }
}