using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Branches
{
    public class AddBranchDTO
    {
        public string Address { get; set; } = string.Empty;

        public string ContactPersonId { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Branch> Map(AddBranchDTO request)
            {
                var employee = await dbContext.Employees
                    .FindAsync(request.ContactPersonId)
                    ?? throw new Exception();

                return new Branch
                {
                    Address = employee.Address,
                    ContactPerson = employee.Name,
                    Email = request.Email,
                    Name = request.Name,
                };
            }
        }
    }
}
