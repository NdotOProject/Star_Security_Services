using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/departments")]
    public class DepartmentController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        private IQueryable<Department> Departments
            => dbContext.Departments
                .Include(d => d.Branch);


        [HttpGet]
        [Route("~/api/branches/{branchId}/departments")]
        public async Task<ActionResult<IEnumerable<DepartmentDTO>>>
            GetDepartments(string branchId)
        {
            var departments = await Departments
                .Where(d => d.BranchId == branchId)
                .ToListAsync();

            return Ok(
                departments.Select(
                    mappers.DepartmentDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDTO>>
            GetDepartmentById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var department = await Departments
                .Where(d => d.Id == id)
                .FirstAsync();

            return department == null
                ? NotFound()
                : Ok(
                    mappers.DepartmentDTOMapper.Map(department)
                );
        }

        [HttpPost]
        public async Task<ActionResult<DepartmentDTO>>
            CreateDepartment(
                [FromBody] CreateDepartmentDTO dto
            )
        {
            if (string.IsNullOrWhiteSpace(dto.BranchId))
            {
                return BadRequest();
            }

            var branch = await dbContext.Branches
                .FindAsync(dto.BranchId);

            if (branch == null)
            {
                return NotFound();
            }

            var department = new Department
            {
                Branch = branch,
                BranchId = branch.Id,
                Description = dto.Description,
                Name = dto.Name,
            };

            await dbContext.Departments.AddAsync(department);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/departments/{department.Id}",
                mappers.DepartmentDTOMapper.Map(department)
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>
            UpdateDepartment(
                string id,
                [FromBody] UpdateDepartmentDTO dto
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

            var rowsAffected = await dbContext.Departments
                .Where(e => e.Id == dto.Id)
                .ExecuteUpdateAsync(department => department
                    .SetProperty(
                        d => d.Description,
                        dto.Description
                    )
                    .SetProperty(d => d.Name, dto.Name)
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var department = await dbContext.Departments
                .FindAsync(id);

            if (department == null)
            {
                return NotFound();
            }

            dbContext.Departments.Remove(department);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
