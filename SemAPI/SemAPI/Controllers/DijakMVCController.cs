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
    public class DijakMVCController : Controller
    {
        private Entities db = new Entities();
        public ActionResult List()
        {
            return View();
        }

        // GET: DijakMVC
        public ActionResult Index()
        {
            return View(db.Dijak.ToList());
        }

        // GET: DijakMVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dijak dijak = db.Dijak.Find(id);
            if (dijak == null)
            {
                return HttpNotFound();
            }
            return View(dijak);
        }

        // GET: DijakMVC/Create
        public ActionResult Create(string def_val)
        {
            Dijak d = new Dijak();
            d.DijRazred = "1.az";
            return View(d);
        }

        // POST: DijakMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DijID,DijIme,DijPriimek,DijRazred,DijDatumRojstva,DijaSlika,DijIDNadDatum,DijIDNadUstanova,DijIDNadPotrditev,DijMati,DijOče,UserID")] Dijak dijak)
        {
            if (ModelState.IsValid)
            {
                db.Dijak.Add(dijak);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dijak);
        }

        // GET: DijakMVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dijak dijak = db.Dijak.Find(id);
            if (dijak == null)
            {
                return HttpNotFound();
            }
            return View(dijak);
        }

        // POST: DijakMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DijID,DijIme,DijPriimek,DijRazred,DijDatumRojstva,DijaSlika,DijIDNadDatum,DijIDNadUstanova,DijIDNadPotrditev,DijMati,DijOče,UserID")] Dijak dijak)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dijak).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dijak);
        }

        // GET: DijakMVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dijak dijak = db.Dijak.Find(id);
            if (dijak == null)
            {
                return HttpNotFound();
            }
            return View(dijak);
        }

        // POST: DijakMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dijak dijak = db.Dijak.Find(id);
            db.Dijak.Remove(dijak);
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
