using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoPadawanTCC.Models;

namespace ProjetoPadawanTCC.Controllers
{
    public class PeriodosController : ApiController
    {
        private ProjetoPadawanTCCContext db = new ProjetoPadawanTCCContext();

        // GET: api/Periodos
        public IQueryable<Periodos> GetPeriodos()
        {
            return db.Periodos;
        }

        // GET: api/Periodos/5
        [ResponseType(typeof(Periodos))]
        public async Task<IHttpActionResult> GetPeriodos(int id)
        {
            Periodos periodos = await db.Periodos.FindAsync(id);
            if (periodos == null)
            {
                return NotFound();
            }

            return Ok(periodos);
        }

        // PUT: api/Periodos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeriodos(int id, Periodos periodos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != periodos.CodigoPeriodo)
            {
                return BadRequest();
            }

            db.Entry(periodos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodosExists(id))
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

        // POST: api/Periodos
        [ResponseType(typeof(Periodos))]
        public async Task<IHttpActionResult> PostPeriodos(Periodos periodos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Periodos.Add(periodos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = periodos.CodigoPeriodo }, periodos);
        }

        // DELETE: api/Periodos/5
        [ResponseType(typeof(Periodos))]
        public async Task<IHttpActionResult> DeletePeriodos(int id)
        {
            Periodos periodos = await db.Periodos.FindAsync(id);
            if (periodos == null)
            {
                return NotFound();
            }

            db.Periodos.Remove(periodos);
            await db.SaveChangesAsync();

            return Ok(periodos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeriodosExists(int id)
        {
            return db.Periodos.Count(e => e.CodigoPeriodo == id) > 0;
        }
    }
}