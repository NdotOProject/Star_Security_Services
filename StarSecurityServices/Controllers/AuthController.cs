using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Auth;
using StarSecurityServices.DTOs.Employees;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<EmployeeDTO>>
            Login(
                [FromBody] LoginRequest request
            )
        {
            var employees = await dbContext.Employees
                .Where(e => e.Code == request.Code)
                .Where(e => e.Password == request.Password)
                .ToListAsync();

            if (employees.Count == 0)
            {
                return BadRequest();
            }

            return Ok(
                mappers.EmployeeDTOMapper.Map(
                    employees.First()
                )
            );
        }

        [HttpPost("update_password")]
        public async Task<ActionResult<EmployeeDTO>>
            UpdatePassword(
                [FromBody] UpdatePasswordRequest request
            )
        {
            if (request.NewPassword != request.ConfirmPassword)
            {
                return BadRequest();
            }

            var rowsAffected = await dbContext.Employees
                .Where(e => e.Code == request.Code)
                .Where(e => e.Password == request.OldPassword)
                .ExecuteUpdateAsync(employee => employee
                    .SetProperty(
                        e => e.Password,
                        request.NewPassword
                    )
                );

            await dbContext.SaveChangesAsync();

            return rowsAffected == 0
                ? NotFound()
                : NoContent();
        }
    }
}
