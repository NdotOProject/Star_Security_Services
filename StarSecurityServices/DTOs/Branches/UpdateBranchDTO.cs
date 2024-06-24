using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Branches
{
    public class UpdateBranchDTO
    {
        public string Id { get; set; } = string.Empty;

        public string ContactPersonId { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Branch> Map(UpdateBranchDTO request)
            {
                var branch = await dbContext.Branches
                        .FindAsync(request.Id)
                    ?? throw new Exception();

                var employee = await dbContext.Employees
                        .FindAsync(request.ContactPersonId)
                    ?? throw new Exception();

                return new Branch
                {
                    Id = branch.Id,
                    Address = branch.Address,
                    ContactPerson = employee.Name,
                    Email = request.Email,
                    Name = request.Name,
                    Departments = branch.Departments,
                };
            }
        }
    }
}
