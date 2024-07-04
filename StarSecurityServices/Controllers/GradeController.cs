using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Grades;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/grades")]
    [ApiController]
    public class GradeController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GradeDTO>>> GetGrades()
        {
            return Ok(
                (await dbContext.Grades.OrderBy(e => e.Name).ToListAsync())
                .Select(
                    mappers.GradeDTOMapper.Map
                )
            );
        }
    }
}
