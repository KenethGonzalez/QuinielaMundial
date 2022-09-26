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
    public class EstadioController : ControllerBase
    {
        private readonly EstadioContext _context;

        public EstadioController(EstadioContext context)
        {
            _context = context;
        }

        // GET: api/Estadio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estadio>>> GetEstadios()
        {
            return await _context.Estadios.ToListAsync();
        }

        // GET: api/Estadio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estadio>> GetEstadio(int id)
        {
            var estadio = await _context.Estadios.FindAsync(id);

            if (estadio == null)
            {
                return NotFound();
            }

            return estadio;
        }

        // PUT: api/Estadio/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadio(int id, Estadio estadio)
        {
            if (id != estadio.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadioExists(id))
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

        // POST: api/Estadio
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estadio>> PostEstadio(Estadio estadio)
        {
            _context.Estadios.Add(estadio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadio", new { id = estadio.Id }, estadio);
        }

        // DELETE: api/Estadio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadio(int id)
        {
            var estadio = await _context.Estadios.FindAsync(id);
            if (estadio == null)
            {
                return NotFound();
            }

            _context.Estadios.Remove(estadio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadioExists(int id)
        {
            return _context.Estadios.Any(e => e.Id == id);
        }
    }
}
