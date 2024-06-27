using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Department : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string BranchId { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public Branch Branch { get; set; } = new();

        public ICollection<Employee> Employees { get; set; } = [];

        #endregion
    }
}
