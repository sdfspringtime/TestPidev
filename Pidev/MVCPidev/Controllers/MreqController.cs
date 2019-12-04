using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPidev.Controllers
{
    public class MreqController : Controller
    {
        // GET: Mreq
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mreq/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mreq/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mreq/Create
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

        // GET: Mreq/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mreq/Edit/5
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

        // GET: Mreq/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mreq/Delete/5
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
