using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Contracts;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/contracts")]
    public class ContractController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        private IQueryable<Contract> Contracts
            => dbContext.Contracts
                .Include(c => c.Client)
                .Include(c => c.Employees)
                .Include(c => c.Services);


        [HttpGet("~/api/clients/{clientId}/contracts")]
        public async Task<ActionResult<IEnumerable<ContractDTO>>>
            GetClientContracts(
                string clientId)
        {
            var contracts = await Contracts
                .Where(c => c.ClientId == clientId)
                .ToListAsync();
            
            return Ok(
                contracts.Select(
                    mappers.ContractDTOMapper.Map
                )
            );
        }

        [HttpGet("~/api/employees/{employeeId}/contracts")]
        public async Task<ActionResult<IEnumerable<ContractDTO>>>
            GetEmployeeContracts(
                string employeeId,
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

            var contracts = await Contracts
                .Where(c => c.Employees
                    .Select(e => e.Id)
                    .Contains(employeeId)
                )
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return Ok(
                contracts.Select(
                    mappers.ContractDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContractDTO>>
            GetContractById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var contracts = Contracts
                .Where(c => c.Id == id);

            return await contracts.AnyAsync()
                ? NotFound()
                : Ok(
                    mappers.ContractDTOMapper.Map(
                        await contracts.FirstAsync()
                    )
                );
        }

        [HttpPost]
        public async Task<ActionResult<ContractDTO>>
            CreateContract(
                [FromBody] CreateContractDTO dto
            )
        {
            if (string.IsNullOrWhiteSpace(dto.Client))
            {
                return BadRequest(); 
            }

            if (dto.Employees.Count == 0)
            {
                return BadRequest();
            }

            if (dto.Services.Count == 0)
            {
                return BadRequest();
            }

            var client = await dbContext.Clients
                .FindAsync(dto.Client);

            if (client == null)
            {
                return BadRequest();
            }

            var employees = new HashSet<Employee>();

            foreach(var employeeId in dto.Employees)
            {
                var e = await dbContext.Employees
                    .FindAsync(employeeId);

                if (e == null)
                {
                    return BadRequest();
                }

                employees.Add(e);
            }

            var services = new HashSet<Service>();

            foreach (var serviceId in dto.Services)
            {
                var s = await dbContext.Services
                    .FindAsync(serviceId);

                if (s == null)
                {
                    return BadRequest();
                }

                services.Add(s);
            }

            var contract = new Contract
            {
                Client = client,
                ClientId = client.Id,
                Employees = employees,
                Services = services,
            };

            await dbContext.Contracts.AddAsync(contract);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/contracts/{contract.Id}",
                mappers.ContractDTOMapper.Map(contract)
            );
        }
    }
}
