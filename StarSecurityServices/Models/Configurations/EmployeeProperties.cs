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
                maxLength: 30,
                required: true
            );

            entity.HasIndex(e => e.Code)
                .IsUnique(true);

            // ContactNumber
            entity.HasStringProperty(
                e => e.ContactNumber,
                maxLength: 15,
                required: true
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
            entity.HasOne(e => e.Role)
                .WithMany(r => r.Employees)
                .HasForeignKey(e => e.RoleId);
        }
    }
}
