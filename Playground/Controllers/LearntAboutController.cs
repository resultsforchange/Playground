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

namespace Playground.Controllers
{
    public class LearntAboutController : Controller
    {
        private readonly GenericUnitOfWork _uow;

        public LearntAboutController()
        {
            _uow = new GenericUnitOfWork();
        }

        public LearntAboutController(GenericUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: LearntAbout
        public ActionResult Index()
        {
            return View(_uow.Repository<LearntAbout>().GetAll().ToList());
        }

        // GET: LearntAbout/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LearntAbout learntAbout = _uow.Repository<LearntAbout>().Get(c => c.Id == id);

            if (learntAbout == null)
            {
                return HttpNotFound();
            }
            return View(learntAbout);
        }

        // GET: LearntAbout/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LearntAbout/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] LearntAbout
                learntAbout)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<LearntAbout>().Add(learntAbout);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(learntAbout);
        }

        // GET: LearntAbout/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LearntAbout learntAbout = _uow.Repository<LearntAbout>().Get(c => c.Id == id);

            if (learntAbout == null)
            {
                return HttpNotFound();
            }
            return View(learntAbout);
        }

        // POST: LearntAbout/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] LearntAbout
                learntAbout)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<LearntAbout>().Attach(learntAbout);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(learntAbout);
        }

        // GET: LearntAbout/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LearntAbout learntAbout = _uow.Repository<LearntAbout>().Get(c => c.Id == id);

            if (learntAbout == null)
            {
                return HttpNotFound();
            }
            return View(learntAbout);
        }

        // POST: LearntAbout/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LearntAbout learntAbout = _uow.Repository<LearntAbout>().Get(c => c.Id == id);
            _uow.Repository<LearntAbout>().Delete(learntAbout);
            _uow.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            {
                if (disposing)
                {
                    _uow.Dispose();
                }
                base.Dispose(disposing);
            }
        }
    }
}
