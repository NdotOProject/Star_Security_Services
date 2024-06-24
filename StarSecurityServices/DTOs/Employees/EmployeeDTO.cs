using StarSecurityServices.Context;
using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Employees
{
    public class EmployeeDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        //
        public DepartmentDTO Department { get; set; } = new();

        //
        public string EducationalQualificationId { get; set; } = string.Empty;

        //
        public string GradeId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper
        {
            private readonly ApplicationDbContext _dbContext;

            private DepartmentDTO.Mapper DepartmentDTOMapper { get; }

            public Mapper(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;

                DepartmentDTOMapper = new();
            }

            public EmployeeDTO Map(Employee employee)
            {
                return new EmployeeDTO
                {
                    Id = employee.Id!,
                    Address = employee.Address,
                    Code = employee.Code,
                    Department = DepartmentDTOMapper.Map(employee.Department),
                };
            }
        }
    }
}
