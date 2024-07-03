using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Clients;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>>
            GetClients()
        {
            var clients = await dbContext.Clients
                .ToListAsync();

            return Ok(
                clients.Select(
                    mappers.ClientDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>>
            GetClientById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var client = await dbContext.Clients
                .FindAsync(id);

            return client == null
                ? NotFound()
                : Ok(
                    mappers.ClientDTOMapper.Map(client)
                );
        }

        [HttpPost]
        public async Task<ActionResult<ClientDTO>>
            CreateClient(
                [FromBody] CreateClientDTO dto
            )
        {
            var client = new Client
            {
                Email = dto.Email,
                Name = dto.Name,
                PhoneNumber = dto.PhoneNumber,
            };

            await dbContext.Clients.AddAsync(client);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/clients/{client.Id}",
                mappers.ClientDTOMapper.Map(client)
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>
            UpdateClient(
                string id,
                [FromBody] UpdateClientDTO dto
            )
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            if (id != dto.Id)
            {
                return BadRequest();
            }

            var rowsAffected = await dbContext.Clients
                .Where(e => e.Id == dto.Id)
                .ExecuteUpdateAsync(client => client
                    .SetProperty(c => c.Email, dto.Email)
                    .SetProperty(c => c.Name, dto.Name)
                    .SetProperty(
                        c => c.PhoneNumber,
                        dto.PhoneNumber
                    )
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>
            DeleteClient(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var client = await dbContext.Clients
                .FindAsync(id);

            if (client == null)
            {
                return NotFound(); 
            }

            dbContext.Clients.Remove(client);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
