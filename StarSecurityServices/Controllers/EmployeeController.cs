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
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        private EmployeeDTO.Mapper EmployeeDTOMapper { get; }

        private CreateEmployeeDTO.Mapper CreateEmployeeRequestMapper { get; }

        private DbSet<Employee> Employees => _dbContext.Employees;

        public EmployeeController(ApplicationDbContext dbContext, Mappers mappers)
        {
            _dbContext = dbContext;
            EmployeeDTOMapper = mappers.EmployeeDTOMapper;
            CreateEmployeeRequestMapper = mappers.CreateEmployeeDTOMapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>>
            GetEmployees(
                [FromQuery(Name = "page")] int page = 1,
                [FromQuery(Name = "size")] int size = 10
            )
        {
            #region Validate input

            if (page < 1)
            {
                return BadRequest();
            }

            if (size < 1)
            {
                return BadRequest();
            }

            #endregion

            #region get and transform data

            var employees = await Employees
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return Ok(employees.Select(EmployeeDTOMapper.Map));   
            
            #endregion
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDTO>>
            GetEmployeeById(string id)
        {
            #region Validate input
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }
            #endregion

            var employee = await Employees.FindAsync(id);

            return employee is null
                ? NotFound()
                : Ok(EmployeeDTOMapper.Map(employee));
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDTO>> CreateEmployee(
            [FromBody] CreateEmployeeDTO request)
        {
            var employee = await CreateEmployeeRequestMapper.Map(request);

            employee = (await _dbContext.AddAsync(employee)).Entity;

            return Created(
                $"api/employees/{employee.Id}",
                EmployeeDTOMapper.Map(employee)
            );
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
