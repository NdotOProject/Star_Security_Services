using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class AchievementConfiguration
        : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> entity)
        {
            entity.HasStringKey();

            entity.HasStringProperty(
                e => e.Name,
                maxLength: 255,
                required: true
            );

            entity.HasStringProperty(e => e.Description);

            entity.HasStringPropertyAsForeignKey(e => e.OwnerId)
                .HasOne(a => a.Owner)
                .WithMany(emp => emp.Achievements)
                .HasForeignKey(e => e.OwnerId);
        }
    }
}
