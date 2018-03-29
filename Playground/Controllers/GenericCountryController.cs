using System.Linq;
using System.Net;
using System.Web.Mvc;
using Playground.Data;
using Playground.Models;

namespace Playground.Controllers
{
    public class GenericCountryController : Controller
    {
        private readonly GenericUnitOfWork _uow;

        public GenericCountryController()
        {
            _uow = new GenericUnitOfWork();
        }

        public GenericCountryController(GenericUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: GenericContacts
        public ActionResult Index()
        {
            return View(_uow.Repository<Country>().GetAll().ToList());
        }

        // GET: GenericContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.Repository<Country>().Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: GenericContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenericContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<Country>().Add(country);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: GenericContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.Repository<Country>().Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: GenericContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                _uow.Repository<Country>().Attach(country);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: GenericContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.Repository<Country>().Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: GenericContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = _uow.Repository<Country>().Get(c => c.Id == id);
            _uow.Repository<Country>().Delete(country);
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
