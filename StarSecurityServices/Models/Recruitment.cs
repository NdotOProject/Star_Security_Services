using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Recruitment : IStringKeyEntity
    {
        #region Entity Properties

        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ManagerId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Vacancies { get; set; } = string.Empty;

        #endregion

        #region Relationship

        public Employee Manager { get; set; } = new();

        #endregion
    }
}
