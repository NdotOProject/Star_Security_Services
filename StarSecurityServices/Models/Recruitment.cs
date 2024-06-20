using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Recruitment : IStringKeyEntity
    {
        public string? Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Vacancies { get; set; } = string.Empty;

        public string ManagerId { get; set; } = string.Empty;

        public Employee Manager { get; set; } = new();
    }
}
