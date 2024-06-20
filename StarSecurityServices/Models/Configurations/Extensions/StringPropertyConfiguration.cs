using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Common;
using System.Linq.Expressions;

namespace StarSecurityServices.Models.Configurations.Extensions
{
    public static class StringPropertyConfiguration
    {
        private const int KEY_LENGTH = 50;

        public static EntityTypeBuilder<T> HasStringKey<T>(
            this EntityTypeBuilder<T> entity
        )
            where T : class, IStringKeyEntity
        {
            entity.HasKey(e => e.Id);

            entity.HasStringProperty(
                e => e.Id,
                maxLength: KEY_LENGTH,
                required: true
            );

            return entity;
        }

        public static EntityTypeBuilder<T> HasStringProperty<T>(
            this EntityTypeBuilder<T> entity,
            Expression<Func<T, string?>> propertyExpression,
            int? maxLength = null,
            bool required = false
        )
            where T : class
        {
            var prop = entity.Property(propertyExpression)
                .IsRequired(required);

            if (maxLength == null)
            {
                prop.HasColumnType("NVARCHAR(max)");
            }
            else
            {
                prop.HasColumnType("NVARCHAR")
                    .HasMaxLength(maxLength ?? 255);
            }

            return entity;
        }

        public static EntityTypeBuilder<T> HasStringPropertyAsForeignKey<T>(
            this EntityTypeBuilder<T> entity,
            Expression<Func<T, string?>> propertyExpression
        )
            where T : class
        {
            entity.HasStringProperty(propertyExpression, KEY_LENGTH, required: true);

            return entity;
        }
    }
}
