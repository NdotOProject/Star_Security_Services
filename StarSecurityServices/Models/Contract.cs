using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Contract : IStringKeyEntity
    {
        public string? Id { get; set; }

        public string ClientId { get; set; } = string.Empty;

        public Client Client { get; set; } = new();

        public ICollection<Employee> Employees { get; set; } = [];

        public ICollection<Service> Services { get; set; } = [];
    }
}
