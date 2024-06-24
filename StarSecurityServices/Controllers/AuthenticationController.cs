using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs.Auth;
using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.Models;

namespace StarSecurityServices.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        private DbSet<Employee> Employees => _dbContext.Employees;

        private EmployeeDTO.Mapper EmployeeDTOMapper { get; }

        public AuthenticationController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            EmployeeDTOMapper = new(_dbContext);
        }

        [HttpPost]
        public async Task<ActionResult> Login(
            [FromBody] LoginRequest request)
        {
            var employees = await Employees
                .Where(e => e.Code == request.Code)
                .ToListAsync();

            if (employees.Count == 0)
            {
                return BadRequest();
            }

            var employee = employees.First();

            if (employee.Password == request.Password)
            {
                return Ok(EmployeeDTOMapper.Map(employee));
            }

            return BadRequest();
        }
    }
}
