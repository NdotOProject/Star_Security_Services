using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class DepartmentProperties
        : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasStringKey();

            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            entity.HasStringProperty(e => e.Description);

            entity.HasStringPropertyIsForeignKey(e => e.BranchId);
        }
    }
}
