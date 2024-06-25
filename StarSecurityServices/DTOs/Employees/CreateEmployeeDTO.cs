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
    }
}
