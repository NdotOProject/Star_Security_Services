using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Recruitments;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/recruitments")]
    [ApiController]
    public class RecruitmentController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        private IQueryable<Recruitment> Recruitments
            => dbContext.Recruitments
                .Include(r => r.Manager);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecruitmentDTO>>>
            GetRecruitments()
        {
            var recruitments = await Recruitments
                .ToListAsync();

            return Ok(
                recruitments.Select(
                    mappers.RecruitmentDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RecruitmentDTO>>
            GetRecruitment(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var recruitment = Recruitments
                .Where(r => r.Id == id);

            return await recruitment.AnyAsync()
                ? NotFound()
                : Ok(
                    mappers.RecruitmentDTOMapper.Map(
                        await recruitment.FirstAsync()
                    )
                );
        }

        [HttpPost]
        public async Task<ActionResult> CreateRecruitment(
            [FromBody] CreateRecruitmentDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Description))
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(dto.ManagerId))
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(dto.Title))
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(dto.Vacancies))
            {
                return BadRequest();
            }

            var manager = await dbContext.Employees
                .FindAsync(dto.ManagerId);

            if (manager == null)
            {
                return NotFound();
            }

            var recruitment = new Recruitment
            {
                Description = dto.Description,
                Manager = manager,
                ManagerId = manager.Id,
                Title = dto.Title,
                Vacancies = dto.Vacancies
            };

            await dbContext.Recruitments.AddAsync(recruitment);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/recruitments/{recruitment.Id}",
                mappers.RecruitmentDTOMapper.Map(recruitment)
            );
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>
            DeleteRecruitment(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var recruitment = await dbContext.Recruitments
                .FindAsync(id);

            if (recruitment == null)
            {
                return NotFound();
            }

            dbContext.Recruitments.Remove(recruitment);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
