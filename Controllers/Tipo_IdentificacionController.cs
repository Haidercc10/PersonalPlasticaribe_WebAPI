using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_PlasticaribeWebAPI.Data;
using Personal_PlasticaribeWebAPI.Models;

namespace Personal_PlasticaribeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipo_IdentificacionController : ControllerBase
    {
        private readonly DataContext _context;

        public Tipo_IdentificacionController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Tipo_Identificacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_Identificacion>>> GetTipos_Identificaciones()
        {
          if (_context.Tipos_Identificaciones == null)
          {
              return NotFound();
          }
            return await _context.Tipos_Identificaciones.ToListAsync();
        }

        // GET: api/Tipo_Identificacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_Identificacion>> GetTipo_Identificacion(string id)
        {
          if (_context.Tipos_Identificaciones == null)
          {
              return NotFound();
          }
            var tipo_Identificacion = await _context.Tipos_Identificaciones.FindAsync(id);

            if (tipo_Identificacion == null)
            {
                return NotFound();
            }

            return tipo_Identificacion;
        }

        // PUT: api/Tipo_Identificacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo_Identificacion(string id, Tipo_Identificacion tipo_Identificacion)
        {
            if (id != tipo_Identificacion.TipoIdent_Id)
            {
                return BadRequest();
            }

            _context.Entry(tipo_Identificacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_IdentificacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tipo_Identificacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipo_Identificacion>> PostTipo_Identificacion(Tipo_Identificacion tipo_Identificacion)
        {
          if (_context.Tipos_Identificaciones == null)
          {
              return Problem("Entity set 'DataContext.Tipos_Identificaciones'  is null.");
          }
            _context.Tipos_Identificaciones.Add(tipo_Identificacion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Tipo_IdentificacionExists(tipo_Identificacion.TipoIdent_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTipo_Identificacion", new { id = tipo_Identificacion.TipoIdent_Id }, tipo_Identificacion);
        }

        // DELETE: api/Tipo_Identificacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo_Identificacion(string id)
        {
            if (_context.Tipos_Identificaciones == null)
            {
                return NotFound();
            }
            var tipo_Identificacion = await _context.Tipos_Identificaciones.FindAsync(id);
            if (tipo_Identificacion == null)
            {
                return NotFound();
            }

            _context.Tipos_Identificaciones.Remove(tipo_Identificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tipo_IdentificacionExists(string id)
        {
            return (_context.Tipos_Identificaciones?.Any(e => e.TipoIdent_Id == id)).GetValueOrDefault();
        }
    }
}
