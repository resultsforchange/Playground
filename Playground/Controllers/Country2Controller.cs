using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Playground.Data;
using Playground.Models;
using Playground.Repositories;

namespace Playground.Controllers
{
    public class Country2Controller : Controller
    {
        private CountryRepository repo = new CountryRepository();

        // GET: Countries2
        public ActionResult Index()
        {
            return View(repo.GetAll().ToList());
        }

        // GET: Countries2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = repo.Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: Countries2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Countries2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                repo.Add(country);
                repo.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: Countries2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = repo.Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: Countries2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                repo.Attach(country);
                repo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: Countries2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = repo.Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: Countries2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = repo.Get(c => c.Id == id);

            repo.Delete(country);
            repo.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose(disposing);
            }
            base.Dispose(disposing);
        }
    }
}
