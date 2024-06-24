using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Employee : IStringKeyEntity
    {
        #region Entity Properties

        public string? Id { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string DepartmentId { get; set; } = string.Empty;

        public string EducationalQualificationId { get; set; } = string.Empty;

        public string GradeId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public ICollection<Achievement> Achievements { get; set; } = [];

        public ICollection<Contract> Contracts { get; set; } = [];

        public Department Department { get; set; } = new();

        public EducationalQualification EducationalQualification { get; set; } = new();

        public Grade Grade { get; set; } = new();

        public ICollection<Recruitment> Recruitments { get; set; } = [];

        public ICollection<Role> Roles { get; set; } = [];

        #endregion
    }
}
