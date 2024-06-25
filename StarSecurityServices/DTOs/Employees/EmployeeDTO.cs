using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.DTOs.EducationalQualifications;
using StarSecurityServices.DTOs.Grades;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Employees
{
    public class EmployeeDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public DepartmentDTO Department { get; set; } = new();

        public EducationalQualificationDTO
            EducationalQualification { get; set; } = new();

        public GradeDTO Grade { get; set; } = new();

        public string Name { get; set; } = string.Empty;

        public class Mapper(
            DepartmentDTO.Mapper departmentDTOMapper,
            EducationalQualificationDTO.Mapper edDTOMapper,
            GradeDTO.Mapper gradeDTOMapper)
        {
            public EmployeeDTO Map(Employee employee)
            {
                return new EmployeeDTO
                {
                    Id = employee.Id!,
                    Address = employee.Address,
                    Code = employee.Code,
                    ContactNumber = employee.ContactNumber,
                    Department = departmentDTOMapper.Map(employee.Department),
                    EducationalQualification = edDTOMapper.Map(
                        employee.EducationalQualification
                    ),
                    Grade = gradeDTOMapper.Map(employee.Grade),
                    Name = employee.Name,
                };
            }
        }
    }
}
