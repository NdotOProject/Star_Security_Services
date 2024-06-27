using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Branch : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Email {  get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public ICollection<Department> Departments { get; set; } = [];

        #endregion
    }
}
