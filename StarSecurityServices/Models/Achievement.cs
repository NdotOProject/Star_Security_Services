using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Achievement : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string OwnerId { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public Employee Owner { get; set; } = new();

        #endregion
    }
}
