namespace StarSecurityServices.DTOs.Achievements
{
    public class CreateAchievementDTO
    {
        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;
    }
}
