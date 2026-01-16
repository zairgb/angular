using FBTrajeta.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBTrajeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrajetaController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public TrajetaController(AplicationDBContext context) 
        {
            _context = context;
        }
        // GET: api/<TrajetaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrajetaCredito>>> Get()
        {
            try
            {
                object listTarjeta = await _context.TrajetaCredito.ToListAsync();
                return Ok(listTarjeta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<TrajetaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TrajetaCredito trajeta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.TrajetaCredito.Add(trajeta);
            await _context.SaveChangesAsync();

            return Ok(trajeta);

        }

        // PUT api/<TrajetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TrajetaCredito trajeta)
        {
            try
            {
                if (id != trajeta.Id)
                {
                    return BadRequest();
                }

                _context.Update(trajeta);
                await _context.SaveChangesAsync();
                return Ok(new {message = "La tarjeta fue actualizada"});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // DELETE api/<TrajetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var trajeta = await _context.TrajetaCredito.FindAsync(id);

                if (trajeta == null)
                {
                    return NotFound();
                }

                _context.TrajetaCredito.Remove(trajeta);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
