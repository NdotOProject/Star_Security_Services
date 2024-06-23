using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class ContractRelationships
        : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> entity)
        {
            // Contract - Client
            entity.HasOne(c => c.Client)
                .WithMany(c => c.Contracts)
                .HasForeignKey(e => e.ClientId);

            // Contract - Employee
            entity.HasMany(e => e.Employees)
                .WithMany(e => e.Contracts)
                .UsingEntity(
                    "EmployeeContracts",
                    l => l.HasOne(typeof(Employee))
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .HasPrincipalKey(nameof(Employee.Id)),
                    r => r.HasOne(typeof(Contract))
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .HasPrincipalKey(nameof(Contract.Id)),
                    j => j.HasKey("EmployeeId", "ContractId")
                );

            // Contract - Service
            entity.HasMany(e => e.Services)
                .WithMany(s => s.Contracts)
                .UsingEntity(
                    "ContractServices",
                    l => l.HasOne(typeof(Service))
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .HasPrincipalKey(nameof(Service.Id)),
                    r => r.HasOne(typeof(Contract))
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .HasPrincipalKey(nameof(Contract.Id)),
                    j => j.HasKey("ContractId", "ServiceId")
                );
        }
    }
}
