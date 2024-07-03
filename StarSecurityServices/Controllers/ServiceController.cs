using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Services;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/services")]
    [ApiController]
    public class ServiceController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceDTO>>>
            GetServices()
        {
            var services = await dbContext.Services
                .ToListAsync();

            return Ok(
                services.Select(
                    mappers.ServiceDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceDTO>>
            GetService(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var service = await dbContext.Services
                .FindAsync(id);

            return service == null
                ? NotFound()
                : Ok(
                    mappers.ServiceDTOMapper.Map(service)
                );
        }

        [HttpPost]
        public async Task<ActionResult<ServiceDTO>>
            CreateService(
                [FromBody] CreateServiceDTO dto
            )
        {
            var service = new Service
            {
                Description = dto.Description,
                Name = dto.Name,
            };

            await dbContext.Services.AddAsync(service);
            
            await dbContext.SaveChangesAsync();

            return Created(
                $"api/services/{service.Id}",
                mappers.ServiceDTOMapper.Map(service)
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>
            UpdateService(
                string id,
                [FromBody] UpdateServiceDTO dto
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

            var rowsAffected = await dbContext.Services
                .Where(e => e.Id == dto.Id)
                .ExecuteUpdateAsync(service => service
                    .SetProperty(
                        s => s.Description,
                        dto.Description
                    )
                    .SetProperty(s => s.Name, dto.Name)
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteService(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var service = await dbContext.Services
                .FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            dbContext.Services.Remove(service);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
