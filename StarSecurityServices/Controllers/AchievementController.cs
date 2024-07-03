using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Achievements;
using StarSecurityServices.Models;
using StarSecurityServices.Models.Database;

namespace StarSecurityServices.Controllers
{
    [Route("api/achievements")]
    [ApiController]
    public class AchievementController(
            ApplicationDbContext dbContext,
            Mappers mappers) : ControllerBase
    {
        private IQueryable<Achievement> Achievements
            => dbContext.Achievements
                .Include(a => a.Owner);

        [HttpGet("~/api/employees/{id}/achievements")]
        public async Task<ActionResult<IEnumerable<AchievementDTO>>>
            GetAchievements(string id)
        {
            var achievements = await Achievements
                .Where(a => a.OwnerId == id)
                .ToListAsync();

            return Ok(
                achievements.Select(
                    mappers.AchievementDTOMapper.Map
                )
            );
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AchievementDTO>>
            GetAchievementById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var achievements = Achievements
                .Where(a => a.Id == id);

            return await achievements.AnyAsync()
                ? NotFound()
                : Ok(
                    mappers.AchievementDTOMapper.Map(
                        await achievements.FirstAsync()
                    )
                );
        }

        [HttpPost]
        public async Task<ActionResult<AchievementDTO>>
            CreateAchievement(
                [FromBody] CreateAchievementDTO request
            )
        {
            var owner = await dbContext.Employees
                .FindAsync(request.OwnerId);

            if (owner == null)
            {
                return BadRequest();
            }

            var achievement = new Achievement
            {
                Description = request.Description,
                Name = request.Name,
                OwnerId = request.OwnerId,
                Owner = owner,
            };

            await dbContext.Achievements.AddAsync(achievement);

            await dbContext.SaveChangesAsync();

            return Created(
                $"api/achievements/{achievement.Id}",
                achievement
            );
        }
    }
}
