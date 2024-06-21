using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Employee : IStringKeyEntity
    {
        public string? Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public ICollection<Achievement> Achievements { get; set; } = [];

        public ICollection<Contract> Contracts { get; set; } = [];

        public string DepartmentId { get; set; } = string.Empty;

        public Department Department { get; set; } = new();

        public string EducationalQualificationId { get; set; } = string.Empty;

        public EducationalQualification EducationalQualification { get; set; } = new();

        public string GradeId { get; set; } = string.Empty;

        public Grade Grade { get; set; } = new();

        public ICollection<Recruitment> Recruitments { get; set; } = [];

        public ICollection<Role> Roles { get; set; } = [];
    }
}
