using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Employees
{
    public class UpdateEmployeeDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string DepartmentId { get; set; } = string.Empty;

        public string EducationalQualificationId { get; set; } = string.Empty;

        public string GradeId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Employee> Map(UpdateEmployeeDTO dto)
            {
                var employee = await dbContext.Employees.FindAsync(dto.Id)
                    ?? throw new Exception();

                var department = await dbContext.Departments.FindAsync(
                        dto.DepartmentId
                    ) ?? throw new Exception();

                var educational = await dbContext.EducationalQualifications
                        .FindAsync(dto.EducationalQualificationId)
                    ?? throw new Exception();

                var grade = await dbContext.Grades.FindAsync(dto.GradeId)
                    ?? throw new Exception();

                return new Employee
                {
                    Id = employee.Id,
                    Achievements = employee.Achievements,
                    Address = dto.Address,
                    Code = employee.Code,
                    Contracts = employee.Contracts,
                    ContactNumber = dto.ContactNumber,
                    Department = department,
                    DepartmentId = dto.DepartmentId,
                    EducationalQualification = educational,
                    EducationalQualificationId = dto.EducationalQualificationId,
                    Grade = grade,
                    GradeId = dto.GradeId,
                    Name = dto.Name,
                    Password = employee.Password,
                    Recruitments = employee.Recruitments,
                    Roles = employee.Roles,
                };
            }
        }
    }
}
