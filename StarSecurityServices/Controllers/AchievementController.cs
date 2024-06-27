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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AchievementDTO>>>
            GetAchievements(
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

            var achievements = await Achievements
                .Skip((page - 1) * size)
                .Take(size)
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
