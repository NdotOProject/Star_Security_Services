using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class BranchRelationships
        : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasOne(e => e.Branch)
                .WithMany(b => b.Departments)
                .HasForeignKey(e => e.BranchId);
        }
    }
}
