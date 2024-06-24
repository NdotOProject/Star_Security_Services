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
            // Id
            entity.HasStringKey();

            // Address
            entity.HasStringProperty(
                e => e.Address,
                maxLength: 255,
                required: true
            );

            // Code
            entity.HasStringProperty(
                e => e.Code,
                maxLength: 10,
                required: true
            );

            // ContactNumber
            entity.HasStringProperty(
                e => e.ContactNumber,
                maxLength: 15,
                required: true
            );

            // DepartmentId
            entity.HasStringPropertyIsForeignKey(
                e => e.DepartmentId
            );

            // EducationalQualificationId
            entity.HasStringPropertyIsForeignKey(
                e => e.EducationalQualificationId
            );

            // GradeId
            entity.HasStringPropertyIsForeignKey(
                e => e.GradeId
            );

            // Name
            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            // Password
            entity.HasStringProperty(
                e => e.Password,
                maxLength: 100,
                required: true
            );
        }
    }
}
