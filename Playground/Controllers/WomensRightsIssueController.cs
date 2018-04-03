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
    public class WomensRightsIssueController : Controller
    {
        private readonly GenericUnitOfWork _uow;

        public WomensRightsIssueController()
        {
            _uow = new GenericUnitOfWork();
        }

        public WomensRightsIssueController(GenericUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: WomensRightsIssue
        public ActionResult Index()
        {
            return View(_uow.Repository<WomensRightsIssue>().GetAll().ToList());
        }

        // GET: WomensRightsIssue/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WomensRightsIssue womensRightsIssue = _uow.Repository<WomensRightsIssue>().Get(c => c.Id == id);

            if (womensRightsIssue == null)
            {
                return HttpNotFound();
            }
            return View(womensRightsIssue);
        }

        // GET: WomensRightsIssue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WomensRightsIssue/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] WomensRightsIssue
                womensRightsIssue)
        {
            {
                if (ModelState.IsValid)
                {
                    _uow.Repository<WomensRightsIssue>().Add(womensRightsIssue);
                    _uow.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(womensRightsIssue);
            }
        }

        // GET: WomensRightsIssue/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WomensRightsIssue womensRightsIssue = _uow.Repository<WomensRightsIssue>().Get(c => c.Id == id);

            if (womensRightsIssue == null)
            {
                return HttpNotFound();
            }
            return View(womensRightsIssue);
        }

        // POST: WomensRightsIssue/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] WomensRightsIssue womensRightsIssue)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<WomensRightsIssue>().Attach(womensRightsIssue);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(womensRightsIssue);
        }

        // GET: WomensRightsIssue/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WomensRightsIssue womensRightsIssue = _uow.Repository<WomensRightsIssue>().Get(c => c.Id == id);

            if (womensRightsIssue == null)
            {
                return HttpNotFound();
            }
            return View(womensRightsIssue);
        }

        // POST: WomensRightsIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WomensRightsIssue womensRightsIssue = _uow.Repository<WomensRightsIssue>().Get(c => c.Id == id);
            _uow.Repository<WomensRightsIssue>().Delete(womensRightsIssue);
            _uow.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _uow.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
