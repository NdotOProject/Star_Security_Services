using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class ContractProperties
        : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> entity)
        {
            // Id
            entity.HasStringKey();

            // ClientId
            entity.HasStringPropertyIsForeignKey(
                e => e.ClientId
            );
        }
    }
}
