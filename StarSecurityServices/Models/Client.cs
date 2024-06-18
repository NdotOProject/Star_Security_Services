using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Client : IStringId
    {
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ServiceId { get; set; } = string.Empty;

        public Service Service { get; set; } = new();
    }
}
