using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class RoleProperties
        : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> entity)
        {
            // Id
            entity.HasStringKey();

            // Description
            entity.HasStringProperty(
                e => e.Description
            );

            // Name
            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );
        }
    }
}
