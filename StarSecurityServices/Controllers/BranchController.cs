using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Branches;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/branches")]
    public class BranchController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BranchDTO>>>
            GetBranches(
                [FromQuery(Name = "page")] int page = 1,
                [FromQuery(Name = "size")] int size = 10
            )
        {
            if (page < 1)
            {
                return BadRequest();
            }

            if (size < 1)
            {
                return BadRequest();
            }

            var branches = await dbContext.Branches
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return Ok(
                branches.Select(
                    mappers.BranchDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BranchDTO>>
            GetBranchById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var branch = await dbContext.Branches
                .FindAsync(id);

            return branch == null
                ? NotFound()
                : Ok(
                    mappers.BranchDTOMapper.Map(branch)
                );
        }

        [HttpPost]
        public async Task<ActionResult<BranchDTO>> AddBrach(
            [FromBody] AddBranchDTO dto)
        {
            var branch = new Branch
            {
                Address = dto.Address,
                ContactPerson = dto.ContactPerson,
                Email = dto.Email,
                Name = dto.Name,
            };

            await dbContext.Branches.AddAsync(branch);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/branches/{branch.Id}",
                mappers.BranchDTOMapper.Map(branch)
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>
            UpdateBranch(
                string id,
                [FromBody] UpdateBranchDTO dto
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

            var rowsAffected = await dbContext.Branches
                .Where(e => e.Id == dto.Id)
                .ExecuteUpdateAsync(branch => branch
                    .SetProperty(
                        b => b.ContactPerson,
                        dto.ContactPerson
                    )
                    .SetProperty(b => b.Email, dto.Email)
                    .SetProperty(b => b.Name, dto.Name)
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }
    }
}
