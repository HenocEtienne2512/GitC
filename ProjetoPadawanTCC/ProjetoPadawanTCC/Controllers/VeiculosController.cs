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
    public class VeiculosController : ApiController
    {
        private ProjetoPadawanTCCContext db = new ProjetoPadawanTCCContext();

        // GET: api/Veiculos
        public IQueryable<Veiculos> GetVeiculos()
        {
            return db.Veiculos;
        }

        // GET: api/Veiculos/5
        [ResponseType(typeof(Veiculos))]
        public async Task<IHttpActionResult> GetVeiculos(int id)
        {
            Veiculos veiculos = await db.Veiculos.FindAsync(id);
            if (veiculos == null)
            {
                return NotFound();
            }

            return Ok(veiculos);
        }

        // PUT: api/Veiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeiculos(int id, Veiculos veiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculos.Id)
            {
                return BadRequest();
            }

            db.Entry(veiculos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculosExists(id))
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

        // POST: api/Veiculos
        [ResponseType(typeof(Veiculos))]
        public async Task<IHttpActionResult> PostVeiculos(Veiculos veiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculos.Add(veiculos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veiculos.Id }, veiculos);
        }

        // DELETE: api/Veiculos/5
        [ResponseType(typeof(Veiculos))]
        public async Task<IHttpActionResult> DeleteVeiculos(int id)
        {
            Veiculos veiculos = await db.Veiculos.FindAsync(id);
            if (veiculos == null)
            {
                return NotFound();
            }

            db.Veiculos.Remove(veiculos);
            await db.SaveChangesAsync();

            return Ok(veiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculosExists(int id)
        {
            return db.Veiculos.Count(e => e.Id == id) > 0;
        }
    }
}