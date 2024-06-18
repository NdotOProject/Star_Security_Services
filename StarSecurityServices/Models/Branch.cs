using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Branch : IStringId
    {
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Email {  get; set; } = string.Empty;

        public Employee ContactPerson { get; set; } = new();

        public ICollection<Department> Departments { get; set; } = [];
    }
}
