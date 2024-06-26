﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarSecurityServices.Models.Configurations.Extensions;

namespace StarSecurityServices.Models.Configurations
{
    public class ClientProperties
        : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entity)
        {
            // Id
            entity.HasStringKey();

            // Name
            entity.HasStringProperty(
                e => e.Name,
                maxLength: 100,
                required: true
            );

            // PhoneNumber
            entity.HasStringProperty(
                e => e.PhoneNumber,
                maxLength: 15,
                required: true
            );

            // Email
            entity.HasStringProperty(
                e => e.Email,
                maxLength: 255,
                required: true
            );
        }
    }
}
