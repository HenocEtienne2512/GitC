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
    public class TipoVeiculosController : ApiController
    {
        private ProjetoPadawanTCCContext db = new ProjetoPadawanTCCContext();

        // GET: api/TipoVeiculos
        public IQueryable<TipoVeiculos> GetTipoVeiculos()
        {
            return db.TipoVeiculos;
        }

        // GET: api/TipoVeiculos/5
        [ResponseType(typeof(TipoVeiculos))]
        public async Task<IHttpActionResult> GetTipoVeiculos(int id)
        {
            TipoVeiculos tipoVeiculos = await db.TipoVeiculos.FindAsync(id);
            if (tipoVeiculos == null)
            {
                return NotFound();
            }

            return Ok(tipoVeiculos);
        }

        // PUT: api/TipoVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTipoVeiculos(int id, TipoVeiculos tipoVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoVeiculos.CodigoTipo)
            {
                return BadRequest();
            }

            db.Entry(tipoVeiculos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoVeiculosExists(id))
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

        // POST: api/TipoVeiculos
        [ResponseType(typeof(TipoVeiculos))]
        public async Task<IHttpActionResult> PostTipoVeiculos(TipoVeiculos tipoVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoVeiculos.Add(tipoVeiculos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tipoVeiculos.CodigoTipo }, tipoVeiculos);
        }

        // DELETE: api/TipoVeiculos/5
        [ResponseType(typeof(TipoVeiculos))]
        public async Task<IHttpActionResult> DeleteTipoVeiculos(int id)
        {
            TipoVeiculos tipoVeiculos = await db.TipoVeiculos.FindAsync(id);
            if (tipoVeiculos == null)
            {
                return NotFound();
            }

            db.TipoVeiculos.Remove(tipoVeiculos);
            await db.SaveChangesAsync();

            return Ok(tipoVeiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoVeiculosExists(int id)
        {
            return db.TipoVeiculos.Count(e => e.CodigoTipo == id) > 0;
        }
    }
}