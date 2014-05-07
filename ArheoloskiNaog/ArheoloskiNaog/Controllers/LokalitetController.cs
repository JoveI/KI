using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArheoloskiNaog.Models;

namespace ArheoloskiNaog.Controllers
{
    public class LokalitetController : Controller
    {
        private ArheologijaDBContext db = new ArheologijaDBContext();

        // GET: /Lokalitet/
        public ActionResult Index()
        {
            return View(db.Localities.ToList());
        }

        // GET: /Lokalitet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalitet lokalitet = db.Localities.Find(id);
            if (lokalitet == null)
            {
                return HttpNotFound();
            }
            return View(lokalitet);
        }

        // GET: /Lokalitet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Lokalitet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Ime,Oblast,Period,PeriodGodini,Detali,Vlez,ImageUrl,Opis")] Lokalitet lokalitet)
        {
            if (ModelState.IsValid)
            {
                db.Localities.Add(lokalitet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lokalitet);
        }

        // GET: /Lokalitet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalitet lokalitet = db.Localities.Find(id);
            if (lokalitet == null)
            {
                return HttpNotFound();
            }
            return View(lokalitet);
        }

        // POST: /Lokalitet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Ime,Oblast,Period,PeriodGodini,Detali,Vlez,ImageUrl,Opis")] Lokalitet lokalitet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lokalitet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lokalitet);
        }

        // GET: /Lokalitet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lokalitet lokalitet = db.Localities.Find(id);
            if (lokalitet == null)
            {
                return HttpNotFound();
            }
            return View(lokalitet);
        }

        // POST: /Lokalitet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lokalitet lokalitet = db.Localities.Find(id);
            db.Localities.Remove(lokalitet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
