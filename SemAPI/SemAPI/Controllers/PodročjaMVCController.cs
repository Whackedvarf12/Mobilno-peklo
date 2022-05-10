using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SemAPI.Models;

namespace SemAPI.Controllers
{
    public class PodročjaMVCController : Controller
    {
        private Entities db = new Entities();

        // GET: PodročjaMVC
        public ActionResult Index()
        {
            return View(db.Področja.ToList());
        }

        // GET: PodročjaMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Področja področja = db.Področja.Find(id);
            if (področja == null)
            {
                return HttpNotFound();
            }
            return View(področja);
        }

        // GET: PodročjaMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PodročjaMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PodID,PodIme")] Področja področja)
        {
            if (ModelState.IsValid)
            {
                db.Področja.Add(področja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(področja);
        }

        // GET: PodročjaMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Področja področja = db.Področja.Find(id);
            if (področja == null)
            {
                return HttpNotFound();
            }
            return View(področja);
        }

        // POST: PodročjaMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PodID,PodIme")] Področja področja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(področja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(področja);
        }

        // GET: PodročjaMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Področja področja = db.Področja.Find(id);
            if (področja == null)
            {
                return HttpNotFound();
            }
            return View(področja);
        }

        // POST: PodročjaMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Področja področja = db.Področja.Find(id);
            db.Področja.Remove(področja);
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
