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
    public class OperationalAreaController : Controller
    {
        private readonly GenericUnitOfWork _uow;

        public OperationalAreaController()
        {
            _uow = new GenericUnitOfWork();
        }

        public OperationalAreaController(GenericUnitOfWork uow)
        {
            _uow = uow;
        }
            
        // GET: OperationalArea
        public ActionResult Index()
        {
            return View(_uow.Repository<OperationalArea>().GetAll().ToList());
        }

        // GET: OperationalArea/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            OperationalArea operationalArea = _uow.Repository<OperationalArea>().Get(c => c.Id == id);

            if (operationalArea == null)
            {
                return HttpNotFound();
            }
            return View(operationalArea);
        }

        // GET: OperationalArea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperationalArea/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] OperationalArea operationalArea)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<OperationalArea>().Add(operationalArea);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operationalArea);
        }

        // GET: OperationalArea/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            OperationalArea operationalArea = _uow.Repository<OperationalArea>().Get(c => c.Id == id);

            if (operationalArea == null)
            {
                return HttpNotFound();
            }
            return View(operationalArea);
        }

        // POST: OperationalArea/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InsertedDateTime,InsertedBy,ModifiedDateTime,ModifiedBy")] OperationalArea operationalArea)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<OperationalArea>().Attach(operationalArea);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operationalArea);
        }

        // GET: OperationalArea/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            OperationalArea operationalArea = _uow.Repository<OperationalArea>().Get(c => c.Id == id);

            if (operationalArea == null)
            {
                return HttpNotFound();
            }
            return View(operationalArea);
        }

        // POST: OperationalArea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OperationalArea operationalArea = _uow.Repository<OperationalArea>().Get(c => c.Id == id);
            _uow.Repository<OperationalArea>().Delete(operationalArea);
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
