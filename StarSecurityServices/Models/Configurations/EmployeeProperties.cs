using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class EmployeeProperties
        : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasStringKey();

            entity.HasStringProperty(
                e => e.Code,
                maxLength: 10,
                required: true
            );

            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            entity.HasStringProperty(
                e => e.Address,
                maxLength: 255,
                required: true
            );

            entity.HasStringProperty(
                e => e.ContactNumber,
                maxLength: 15,
                required: true
            );

            //entity.

        }
    }
}
