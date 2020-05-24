using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Janssen.Core.Web.Controllers
{
    public class EnrollController : Controller
    {
        // GET: Enroll
        public ActionResult Index()
        {
            return View();
        }

        // GET: Enroll/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Enroll/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enroll/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Enroll/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enroll/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Enroll/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enroll/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}