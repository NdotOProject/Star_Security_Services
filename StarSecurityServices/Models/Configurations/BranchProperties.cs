using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class BranchProperties
        : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> entity)
        {
            // Id
            entity.HasStringKey();

            // Name
            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            // Address
            entity.HasStringProperty(
                e => e.Address,
                maxLength: 255,
                required: true
            );

            // Email
            entity.HasStringProperty(
                e => e.Email,
                maxLength: 255,
                required: true
            );

            // ContactPerson
            entity.HasStringProperty(
                e => e.ContactPerson,
                maxLength: 100,
                required: true
            );
        }
    }
}
