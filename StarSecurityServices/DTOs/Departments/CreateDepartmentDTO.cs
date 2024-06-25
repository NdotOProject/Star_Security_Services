using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Departments
{
    public class CreateDepartmentDTO
    {
        public string BranchId { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Department> Map(CreateDepartmentDTO dto)
            {
                var branch = await dbContext.Branches.FindAsync(dto.BranchId)
                    ?? throw new Exception();

                return new Department
                {
                    Branch = branch,
                    BranchId = dto.BranchId,
                    Description = dto.Description,
                    Name = dto.Name,
                };
            }
        }
    }
}
