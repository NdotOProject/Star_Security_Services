using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Branches
{
    public class BranchDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper
            : AbstractMapper<Branch, BranchDTO>
        {
            public override BranchDTO Map(Branch branch)
            {
                return new BranchDTO
                {
                    Id = branch.Id,
                    Address = branch.Address,
                    ContactPerson = branch.ContactPerson,
                    Email = branch.Email,
                    Name = branch.Name,
                };
            }
        }
    }
}
