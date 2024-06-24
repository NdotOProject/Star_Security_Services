using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Achievements
{
    public class AchievementDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public AchievementOwner Owner { get; set; } = new();

        public class Mapper
        {
            public AchievementDTO Map(Achievement achievement)
            {
                return new AchievementDTO
                {
                    Id = achievement.Id!,
                    Name = achievement.Name,
                    Description = achievement.Description,
                    Owner = new AchievementOwner
                    {
                        Id = achievement.Owner.Id!,
                        Name = achievement.Owner.Name,
                    },
                };
            } 
        }
    }

    public class AchievementOwner
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}
