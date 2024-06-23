using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Client : IStringKeyEntity
    {
        #region Entity Properties

        public string? Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public ICollection<Contract> Contracts { get; set; } = [];

        #endregion
    }
}
