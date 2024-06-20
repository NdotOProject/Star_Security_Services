using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Achievement : IStringKeyEntity
    {
        public string? Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;

        public Employee Owner { get; set; } = new();
    }
}
