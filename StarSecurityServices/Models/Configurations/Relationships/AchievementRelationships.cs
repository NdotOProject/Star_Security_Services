using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class AchievementRelationships
        : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> entity)
        {
            entity.HasOne(a => a.Owner)
                .WithMany(emp => emp.Achievements)
                .HasForeignKey(e => e.OwnerId);
        }
    }
}
