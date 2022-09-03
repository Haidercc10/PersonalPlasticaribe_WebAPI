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
    public class Tipos_EstadosController : ControllerBase
    {
        private readonly DataContext _context;

        public Tipos_EstadosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Tipos_Estados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipos_Estados>>> GetTipos_Estados()
        {
          if (_context.Tipos_Estados == null)
          {
              return NotFound();
          }
            return await _context.Tipos_Estados.ToListAsync();
        }

        // GET: api/Tipos_Estados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipos_Estados>> GetTipos_Estados(int id)
        {
          if (_context.Tipos_Estados == null)
          {
              return NotFound();
          }
            var tipos_Estados = await _context.Tipos_Estados.FindAsync(id);

            if (tipos_Estados == null)
            {
                return NotFound();
            }

            return tipos_Estados;
        }

        // PUT: api/Tipos_Estados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipos_Estados(int id, Tipos_Estados tipos_Estados)
        {
            if (id != tipos_Estados.TpEstado_Id)
            {
                return BadRequest();
            }

            _context.Entry(tipos_Estados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipos_EstadosExists(id))
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

        // POST: api/Tipos_Estados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipos_Estados>> PostTipos_Estados(Tipos_Estados tipos_Estados)
        {
          if (_context.Tipos_Estados == null)
          {
              return Problem("Entity set 'DataContext.Tipos_Estados'  is null.");
          }
            _context.Tipos_Estados.Add(tipos_Estados);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipos_Estados", new { id = tipos_Estados.TpEstado_Id }, tipos_Estados);
        }

        // DELETE: api/Tipos_Estados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipos_Estados(int id)
        {
            if (_context.Tipos_Estados == null)
            {
                return NotFound();
            }
            var tipos_Estados = await _context.Tipos_Estados.FindAsync(id);
            if (tipos_Estados == null)
            {
                return NotFound();
            }

            _context.Tipos_Estados.Remove(tipos_Estados);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tipos_EstadosExists(int id)
        {
            return (_context.Tipos_Estados?.Any(e => e.TpEstado_Id == id)).GetValueOrDefault();
        }
    }
}
