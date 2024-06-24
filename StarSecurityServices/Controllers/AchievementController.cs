using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Context;
using StarSecurityServices.DTOs;
using StarSecurityServices.DTOs.Achievements;
using StarSecurityServices.Models;

namespace StarSecurityServices.Controllers
{
    [ApiController]
    [Route("api/achievements")]
    public class AchievementController(
            ApplicationDbContext dbContext,
            Mappers mappers
        ) : ControllerBase
    {
        private DbSet<Achievement> Achievements => dbContext.Achievements;

        private AchievementDTO.Mapper AchievementDTOMapper
            => mappers.AchievementDTOMapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AchievementDTO>>>
            GetAchievements(
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

            var achievements = await Achievements
                .Skip((page - 1) * size)
                .ToListAsync();

            return Ok(achievements.Select(AchievementDTOMapper.Map));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AchievementDTO>>
            GetAchievementById(string id)
        {
            #region Validate input
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }
            #endregion

            var achievement = await Achievements.FindAsync(id);

            return achievement is null
                ? NotFound()
                : Ok(AchievementDTOMapper.Map(achievement));
        }

        [HttpPost]
        public void CreateAchievement(
            [FromBody] CreateAchievementDTO request)
        {
        }
    }
}
