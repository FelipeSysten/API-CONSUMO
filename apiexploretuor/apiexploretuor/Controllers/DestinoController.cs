using apiexploretuor.Data;
using apiexploretuor.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiexploretuor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private readonly DataContext _context;

        public DestinoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Destino>>> GetAllDestinos()
        {
            var destinos = await _context.destinos.ToListAsync();
            return Ok(destinos);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Destino>> GetDestino(int id)
        {
            var destino = await _context.destinos.FindAsync(id);
            if (destino is null)
                return NotFound("Destino not found");
            return Ok(destino);
        }

        [HttpPost]

        public async Task<ActionResult<List<Destino>>> AddDestino(Destino destino)
        {
            _context.destinos.Add(destino);
            await _context.SaveChangesAsync();
            return Ok(await _context.destinos.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<Destino>>> UpdateDestino(Destino updateDestino)
        {
            var dbDestino = await _context.destinos.FindAsync(updateDestino.Id);
            if (dbDestino is null)
                return NotFound("Destino not found");

            dbDestino.Title = updateDestino.Title;
            dbDestino.Description = updateDestino.Description;
            dbDestino.DestinoUrl = updateDestino.DestinoUrl;
            

            await _context.SaveChangesAsync();
            return Ok(await _context.destinos.ToListAsync());

        }

        [HttpDelete]

        public async Task<ActionResult<List<Destino>>> DeleteDestino(int id)
        {
            var dbDestino = await _context.destinos.FindAsync(id);
            if (dbDestino is null)
                return NotFound("Destino not found");
            _context.destinos.Remove(dbDestino);

            await _context.SaveChangesAsync();
            return Ok(await _context.destinos.ToListAsync());
        }

    }
}
