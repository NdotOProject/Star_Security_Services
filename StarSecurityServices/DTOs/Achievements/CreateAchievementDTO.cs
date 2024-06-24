using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Achievements
{
    public class CreateAchievementDTO
    {
        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Achievement> Map(
                CreateAchievementDTO achievement)
            {
                var owner = await dbContext.Employees
                    .FindAsync(achievement.OwnerId)
                    ?? throw new Exception();

                return new Achievement
                {
                    Description = achievement.Description,
                    Name = achievement.Name,
                    OwnerId = achievement.OwnerId,
                    Owner = owner,
                };
            }
        }
    }
}
