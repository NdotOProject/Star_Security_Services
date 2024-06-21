using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class ClientRelationships
        : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> entity)
        {
            entity.HasOne(e => e.Client)
                .WithMany(c => c.Contracts)
                .HasForeignKey(e => e.ClientId);
        }
    }
}
