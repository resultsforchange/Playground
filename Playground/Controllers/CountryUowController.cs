using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Playground.Data;
using Playground.Models;

namespace Playground.Controllers
{
    public class CountryUowController : Controller
    {
        private UnitOfWork _uow = null;

        public CountryUowController()
        {
            _uow = new UnitOfWork();
        }

        public CountryUowController(UnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: CountriesUow
        public ActionResult Index()
        {
            return View(_uow.CountryRepository.GetAll().ToList());
        }

        // GET: CountriesUow/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.CountryRepository.Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // GET: CountriesUow/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountriesUow/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                _uow.CountryRepository.Add(country);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: CountriesUow/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.CountryRepository.Get(c => c.Id ==id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: CountriesUow/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,InsertedDateTime,ModifiedDateTime")] Country country)
        {
            if (ModelState.IsValid)
            {
                _uow.CountryRepository.Attach(country);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: CountriesUow/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _uow.CountryRepository.Get(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: CountriesUow/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = _uow.CountryRepository.Get(c => c.Id == id);

            _uow.CountryRepository.Delete(country);
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
