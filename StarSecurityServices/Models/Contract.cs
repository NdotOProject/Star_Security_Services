using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Contract : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string ClientId { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public Client Client { get; set; } = new();

        public ICollection<Employee> Employees { get; set; } = [];

        public ICollection<Service> Services { get; set; } = [];

        #endregion
    }
}
