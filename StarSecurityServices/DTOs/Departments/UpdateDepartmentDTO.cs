using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Departments
{
    public class UpdateDepartmentDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public IEnumerable<string> EmployeeIds { get; set; } = [];

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Department> Map(UpdateDepartmentDTO dto)
            {
                var department = await dbContext.Departments.FindAsync(dto.Id)
                    ?? throw new Exception();

                var employees = new HashSet<Employee>();

                foreach (var employeeId in dto.EmployeeIds)
                {
                    var e = await dbContext.Employees.FindAsync(employeeId)
                        ?? throw new Exception();

                    employees.Add(e);
                }

                return new Department
                {
                    Id = dto.Id,
                    Branch = department.Branch,
                    BranchId = department.BranchId,
                    Description = dto.Description,
                    Name = dto.Name,
                    Employees = employees,
                };
            }
        }
    }
}
