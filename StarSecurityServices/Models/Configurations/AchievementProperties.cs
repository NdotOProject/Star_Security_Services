using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class AchievementProperties
        : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> entity)
        {
            entity.HasStringKey();

            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            entity.HasStringProperty(e => e.Description);

            entity.HasStringPropertyIsForeignKey(e => e.OwnerId);
        }
    }
}
