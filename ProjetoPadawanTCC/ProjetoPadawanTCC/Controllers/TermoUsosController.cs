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
    public class TermoUsosController : ApiController
    {
        private ProjetoPadawanTCCContext db = new ProjetoPadawanTCCContext();

        // GET: api/TermoUsos
        public IQueryable<TermoUso> GetTermoUsoes()
        {
            return db.TermoUsoes;
        }

        // GET: api/TermoUsos/5
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> GetTermoUso(int id)
        {
            TermoUso termoUso = await db.TermoUsoes.FindAsync(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            return Ok(termoUso);
        }

        // PUT: api/TermoUsos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermoUso(int id, TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoUso.CodigoTermo)
            {
                return BadRequest();
            }

            db.Entry(termoUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoUsoExists(id))
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

        // POST: api/TermoUsos
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> PostTermoUso(TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TermoUsoes.Add(termoUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termoUso.CodigoTermo }, termoUso);
        }

        // DELETE: api/TermoUsos/5
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> DeleteTermoUso(int id)
        {
            TermoUso termoUso = await db.TermoUsoes.FindAsync(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            db.TermoUsoes.Remove(termoUso);
            await db.SaveChangesAsync();

            return Ok(termoUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoUsoExists(int id)
        {
            return db.TermoUsoes.Count(e => e.CodigoTermo == id) > 0;
        }
    }
}