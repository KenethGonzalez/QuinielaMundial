﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiniela.Models;

namespace Quiniela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JornadaController : ControllerBase
    {
        private readonly JornadaContext _context;

        public JornadaController(JornadaContext context)
        {
            _context = context;
        }

        // GET: api/Jornada
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jornada>>> GetJornadas()
        {
            return await _context.Jornadas.ToListAsync();
        }

        // GET: api/Jornada/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jornada>> GetJornada(int id)
        {
            var jornada = await _context.Jornadas.FindAsync(id);

            if (jornada == null)
            {
                return NotFound();
            }

            return jornada;
        }

        // PUT: api/Jornada/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJornada(int id, Jornada jornada)
        {
            if (id != jornada.Id)
            {
                return BadRequest();
            }

            _context.Entry(jornada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JornadaExists(id))
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

        // POST: api/Jornada
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jornada>> PostJornada(Jornada jornada)
        {
            _context.Jornadas.Add(jornada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJornada", new { id = jornada.Id }, jornada);
        }

        // DELETE: api/Jornada/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJornada(int id)
        {
            var jornada = await _context.Jornadas.FindAsync(id);
            if (jornada == null)
            {
                return NotFound();
            }

            _context.Jornadas.Remove(jornada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JornadaExists(int id)
        {
            return _context.Jornadas.Any(e => e.Id == id);
        }
    }
}
