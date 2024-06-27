using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Roles
{
    public class RoleDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper
            : AbstractMapper<Role, RoleDTO>
        {
            public override RoleDTO Map(Role o)
            {
                return new RoleDTO
                {
                    Description = o.Description,
                    Id = o.Id,
                    Name = o.Name,
                };
            }
        }
    }
}
