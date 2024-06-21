using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class EmployeeContractConfiguration
        : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> entity)
        {
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
        }
    }
}
