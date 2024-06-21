using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class ContractServiceConfiguration
        : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> entity)
        {
            entity.HasMany(e => e.Services)
                .WithMany(s => s.Contracts)
                .UsingEntity(
                    "ContractServices",
                    l => l.HasOne(typeof(Contract))
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .HasPrincipalKey(nameof(Contract.Id)),
                    r => r.HasOne(typeof(Service))
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .HasPrincipalKey(nameof(Service.Id)),
                    j => j.HasKey("ContractId", "ServiceId")
                );
        }
    }
}
