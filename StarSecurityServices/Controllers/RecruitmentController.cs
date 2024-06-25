using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.Controllers
{
    [Route("api/recruitments")]
    [ApiController]
    public class RecruitmentController(
            ApplicationDbContext dbContext
        ) : ControllerBase
    {
        private DbSet<Recruitment> Recruitments => dbContext.Recruitments;

        [HttpGet]
        public IEnumerable<string> GetRecruitments()
        {
            return new string[] { "value1", "value2" };
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
