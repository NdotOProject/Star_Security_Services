using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Client : IStringKeyEntity
    {
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public ICollection<Contract> Contracts { get; set; } = [];
    }
}
