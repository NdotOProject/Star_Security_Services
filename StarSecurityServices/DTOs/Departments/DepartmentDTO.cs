using StarSecurityServices.DTOs.Branches;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Departments
{
    public class DepartmentDTO
    {
        public string Id { get; set; } = string.Empty;

        public BranchDTO Branch { get; set; } = new();

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(BranchDTO.Mapper branchDTOMapper)
        {
            public DepartmentDTO Map(Department department)
            {
                return new DepartmentDTO
                {
                    Id = department.Id!,
                    Branch = branchDTOMapper.Map(department.Branch),
                    Description = department.Description,
                    Name = department.Name,
                };
            }
        }
    }
}
