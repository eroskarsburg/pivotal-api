using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pivotal.Application.DataAccess.Context;
using Pivotal.Domain.Entities;

namespace Pivotal.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAllClients()
        {
            var clients = await _context.Clients.ToListAsync();
            if (clients.Count == 0)
                return NotFound();

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<List<Client>>> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return Ok(await _context.Clients.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Client>>> UpdateClient(Client updatedClient)
        {
            var client = await _context.Clients.FindAsync(updatedClient.Id);
            if (client is null)
                return NotFound();

            client.Name = updatedClient.Name;
            client.Gender = updatedClient.Gender;
            client.Age = updatedClient.Age;

            await _context.SaveChangesAsync();

            return Ok(await _context.Clients.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Client>>> DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is null)
                return NotFound();

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return Ok(await _context.Clients.ToListAsync());
        }
    }
}
