using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class BranchRelationships
        : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> entity)
        {
            // Branch - Department
            entity.HasMany(b => b.Departments)
                .WithOne(d => d.Branch)
                .HasForeignKey(d => d.BranchId);
        }
    }
}
