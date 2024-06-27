using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class EducationalQualification : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public ICollection<Employee> Employees { get; set; } = [];

        #endregion
    }
}
