using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Achievements
{
    public class AchievementDTO
    {
        public string Id { get; } = string.Empty;

        public string Description { get; } = string.Empty;

        public string Name { get; } = string.Empty;

        public AchievementOwner Owner { get; } = new();

        private AchievementDTO(Achievement achievement)
        {
            Id = achievement.Id!;
            Description = achievement.Description;
            Name = achievement.Name;
            Owner = new AchievementOwner
            {
                Id = achievement.Owner.Id!,
                Name = achievement.Owner.Name,
            };
        }

        public class Mapper
            : AbstractMapper<Achievement, AchievementDTO>
        {
            public override AchievementDTO Map(
                Achievement achievement)
            {
                return new AchievementDTO(achievement);
            }
        }
    }

    public class AchievementOwner
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}
