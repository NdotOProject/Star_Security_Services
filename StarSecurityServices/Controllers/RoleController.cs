using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Roles;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/roles")]
    [ApiController]
    public class RoleController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleDTO>>>
            GetRoles()
        {
            var roles = await dbContext.Roles
                .ToListAsync();

            return Ok(
                roles.Select(
                    mappers.RoleDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDTO>>
            GetRole(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var role = await dbContext.Roles
                .FindAsync(id);

            return role == null
                ? NotFound()
                : Ok(
                    mappers.RoleDTOMapper.Map(role)
                );
        }
    }
}
