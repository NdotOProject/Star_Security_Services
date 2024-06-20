using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Branch : IStringKeyEntity
    {
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Email {  get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public ICollection<Department> Departments { get; set; } = [];
    }
}
