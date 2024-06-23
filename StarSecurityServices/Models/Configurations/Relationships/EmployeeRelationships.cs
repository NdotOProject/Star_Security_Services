using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StarSecurityServices.Models.Configurations.Relationships
{
    public class EmployeeRelationships
        : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            // Employee - Achievement
            entity.HasMany(e => e.Achievements)
                .WithOne(a => a.Owner)
                .HasForeignKey(a => a.OwnerId);

            // Employee - Department
            entity.HasOne(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentId);

            // Employee - Educational Qualification
            entity.HasOne(e => e.EducationalQualification)
                .WithMany(eq => eq.Employees)
                .HasForeignKey(e => e.EducationalQualificationId);

            // Employee - Grade
            entity.HasOne(e => e.Grade)
                .WithMany(g => g.Employees)
                .HasForeignKey(e => e.GradeId);

            // Employee - Recruitment
            entity.HasMany(e => e.Recruitments)
                .WithOne(r => r.Manager)
                .HasForeignKey(r => r.ManagerId);

            // Employee - Role
            entity.HasMany(e => e.Roles)
                .WithMany(r => r.Employees)
                .UsingEntity(
                    "EmployeeRoles",
                    l => l.HasOne(typeof(Role))
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .HasPrincipalKey(nameof(Role.Id)),
                    r => r.HasOne(typeof(Employee))
                    .WithMany()
                    .HasForeignKey("EmployeeId")
                    .HasPrincipalKey(nameof(Employee.Id)),
                    j => j.HasKey("EmployeeId", "RoleId")
                );
        }
    }
}
