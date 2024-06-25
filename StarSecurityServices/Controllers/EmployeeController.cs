using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.Models;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>>
            GetEmployees(
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

            var employees = await dbContext.Employees
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return Ok(
                employees.Select(
                    mappers.EmployeeDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDTO>>
            GetEmployeeById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var employee = await dbContext.Employees
                .FindAsync(id);

            return employee == null
                ? NotFound()
                : Ok(
                    mappers.EmployeeDTOMapper.Map(employee)
                );
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDTO>>
            CreateEmployee(
                [FromBody] CreateEmployeeDTO dto
            )
        {
            var employee = new Employee
            {
                Address = dto.Address,
                Code = dto.Code,
                ContactNumber = dto.ContactNumber,
                DepartmentId = dto.DepartmentId,
                EducationalQualificationId =
                    dto.EducationalQualificationId,
                GradeId = dto.GradeId,
                Name = dto.Name,
                Password = dto.DefaultPassword,
            };

            await dbContext.Employees.AddAsync(employee);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/employees/{employee.Id}",
                mappers.EmployeeDTOMapper.Map(employee)
            );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>
            UpdateEmployee(
                string id,
                [FromBody] UpdateEmployeeDTO dto
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

            var rowsAffected = await dbContext.Employees
                .Where(e => e.Id == dto.Id)
                .ExecuteUpdateAsync(employee => employee
                    .SetProperty(e => e.Address, dto.Address)
                    .SetProperty(
                        e => e.ContactNumber,
                        dto.ContactNumber
                    )
                    .SetProperty(
                        e => e.DepartmentId,
                        dto.DepartmentId
                    )
                    .SetProperty(
                        e => e.EducationalQualificationId,
                        dto.EducationalQualificationId
                    )
                    .SetProperty(e => e.GradeId, dto.GradeId)
                    .SetProperty(e => e.Name, dto.Name)
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var employee = await dbContext.Employees
                .FindAsync(id);

            if (employee == null)
            {
                return NotFound(); 
            }

            dbContext.Employees.Remove(employee);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
