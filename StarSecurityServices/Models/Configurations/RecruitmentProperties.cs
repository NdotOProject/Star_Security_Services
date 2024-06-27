using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class RecruitmentProperties
        : IEntityTypeConfiguration<Recruitment>
    {
        public void Configure(EntityTypeBuilder<Recruitment> entity)
        {
            // Id
            entity.HasStringKey();

            // Description
            entity.HasStringProperty(
                e => e.Description
            );

            // Title
            entity.HasStringProperty(
                e => e.Title,
                maxLength: 100,
                required: true
            );

            // Vacancies
            entity.HasStringProperty(
                e => e.Vacancies,
                maxLength: 255,
                required: true
            );
        }
    }
}
