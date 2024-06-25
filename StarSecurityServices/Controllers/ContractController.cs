using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Contracts;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    //[Route("api/contracts")]
    public class ContractController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        [HttpGet("api/clients/{id}/contracts")]
        public async Task<ActionResult<IEnumerable<ContractDTO>>>
            GetClientContracts(
                string id,
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

            var contracts = await dbContext.Contracts
                .Where(c => c.ClientId == id)
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
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
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
