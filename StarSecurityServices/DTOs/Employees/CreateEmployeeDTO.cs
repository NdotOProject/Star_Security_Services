using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Employees
{
    public class CreateEmployeeDTO
    {
        public string Address { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string DefaultPassword { get; set; } = string.Empty;
        
        public string DepartmentId { get; set; } = string.Empty;

        public string EducationalQualificationId { get; set; } = string.Empty;

        public string GradeId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Employee> Map(CreateEmployeeDTO request)
            {
                var department = await dbContext.Departments
                    .FindAsync(request.DepartmentId)
                    ?? throw new Exception();

                var educational = await dbContext.EducationalQualifications
                    .FindAsync(request.EducationalQualificationId)
                    ?? throw new Exception();

                var grade = await dbContext.Grades
                    .FindAsync(request.GradeId)
                    ?? throw new Exception();

                return new Employee
                {
                    Address = request.Address,
                    Code = request.Code,
                    ContactNumber = request.ContactNumber,
                    DepartmentId = request.DepartmentId,
                    Department = department,
                    EducationalQualificationId
                        = request.EducationalQualificationId,
                    EducationalQualification = educational,
                    GradeId = request.GradeId,
                    Grade = grade,
                    Name = request.Name,
                    Password = request.DefaultPassword,
                };
            }
        }
    }
}
