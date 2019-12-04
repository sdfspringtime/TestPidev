using Pidev.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPidev.Controllers
{
    public class MissionRequestController : Controller
    {
        IMissionRequestService missionRequestService = null;

        public MissionRequestController()
        {
            missionRequestService = new MissionRequestService();
        }
        // GET: MissionRequest
        public ActionResult Index()
        {
            return View(missionRequestService.GetMany());
        }

        // GET: MissionRequest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MissionRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionRequest/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionRequest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MissionRequest/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionRequest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MissionRequest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
