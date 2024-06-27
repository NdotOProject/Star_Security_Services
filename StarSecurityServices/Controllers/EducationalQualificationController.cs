using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.EducationalQualifications;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/educational_qualifications")]
    [ApiController]
    public class EducationalQualificationController(
        ApplicationDbContext dbContext,
        Mappers mappers) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<
                IEnumerable<EducationalQualificationDTO>>>
            GetEducationalQualifications()
        {
            var eds = await dbContext.EducationalQualifications
                .ToListAsync();

            return Ok(
                eds.Select(
                    mappers.EducationalQualificationDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EducationalQualificationDTO>>
            GetEducationalQualification(string id)
        {
            var ed = await dbContext.EducationalQualifications
                .FindAsync(id);

            return ed == null
                ? NotFound()
                : Ok(
                    mappers.EducationalQualificationDTOMapper.Map(ed)
                );
        }
    }
}
