using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SemAPI.Models;

namespace SemAPI.Controllers
{
    public class DijaksController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Dijaks
        public IQueryable<Dijak> GetDijak()
        {
            return db.Dijak;
        }

        // GET: api/Dijaks/5
        [ResponseType(typeof(Dijak))]
        public IHttpActionResult GetDijak(int id)
        {
            Dijak dijak = db.Dijak.Find(id);
            if (dijak == null)
            {
                return NotFound();
            }

            return Ok(dijak);
        }

        // PUT: api/Dijaks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDijak(int id, Dijak dijak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dijak.DijID)
            {
                return BadRequest();
            }

            db.Entry(dijak).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DijakExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Dijaks
        [ResponseType(typeof(Dijak))]
        public IHttpActionResult PostDijak(Dijak dijak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dijak.Add(dijak);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dijak.DijID }, dijak);
        }

        // DELETE: api/Dijaks/5
        [ResponseType(typeof(Dijak))]
        public IHttpActionResult DeleteDijak(int id)
        {
            Dijak dijak = db.Dijak.Find(id);
            if (dijak == null)
            {
                return NotFound();
            }

            db.Dijak.Remove(dijak);
            db.SaveChanges();

            return Ok(dijak);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DijakExists(int id)
        {
            return db.Dijak.Count(e => e.DijID == id) > 0;
        }
    }
}