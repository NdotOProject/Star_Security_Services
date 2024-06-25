using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Branches
{
    public class AddBranchDTO
    {
        public string Address { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
    }
}
