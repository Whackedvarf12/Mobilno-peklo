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
    public class RazrednikisController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Razrednikis
        public IQueryable<Razredniki> GetRazredniki()
        {
            return db.Razredniki;
        }

        // GET: api/Razrednikis/5
        [ResponseType(typeof(Razredniki))]
        public IHttpActionResult GetRazredniki(string id)
        {
            Razredniki razredniki = db.Razredniki.Find(id);
            if (razredniki == null)
            {
                return NotFound();
            }

            return Ok(razredniki);
        }

        // PUT: api/Razrednikis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRazredniki(string id, Razredniki razredniki)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != razredniki.RazRazred)
            {
                return BadRequest();
            }

            db.Entry(razredniki).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazrednikiExists(id))
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

        // POST: api/Razrednikis
        [ResponseType(typeof(Razredniki))]
        public IHttpActionResult PostRazredniki(Razredniki razredniki)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Razredniki.Add(razredniki);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RazrednikiExists(razredniki.RazRazred))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = razredniki.RazRazred }, razredniki);
        }

        // DELETE: api/Razrednikis/5
        [ResponseType(typeof(Razredniki))]
        public IHttpActionResult DeleteRazredniki(string id)
        {
            Razredniki razredniki = db.Razredniki.Find(id);
            if (razredniki == null)
            {
                return NotFound();
            }

            db.Razredniki.Remove(razredniki);
            db.SaveChanges();

            return Ok(razredniki);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RazrednikiExists(string id)
        {
            return db.Razredniki.Count(e => e.RazRazred == id) > 0;
        }
    }
}