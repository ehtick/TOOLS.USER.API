﻿using APPLICATION.DOMAIN.ENTITY.COMPANY;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APPLICATION.INFRAESTRUTURE.CONTEXTO.CONFIGUREDATATYPES.COMPANY;

public class CompanyTypesConfiguration : IEntityTypeConfiguration<CompanyEntity>
{
    public void Configure(EntityTypeBuilder<CompanyEntity> builder)
    {
        // Renomeando nome.
        builder.ToTable("Companies").HasKey(company => company.Id);

        // Guid
        builder.Property(company => company.Id).IsRequired();
        builder.Property(company => company.PlanId).IsRequired();
        builder.Property(company => company.CreatedUserId).IsRequired();
        builder.Property(company => company.UpdatedUserId).IsRequired();

        // String
        builder.Property(company => company.Name).IsRequired();
        builder.Property(company => company.Description).HasMaxLength(80);

        // Enum
        builder.Property(company => company.Status).IsRequired();

        // DateTime
        builder.Property(company => company.StartDate);
        builder.Property(company => company.Created);
        builder.Property(company => company.Updated);

        // Vinculo com pessoas.
        builder
            .HasMany(company => company.Persons).WithOne(person => person.Company).HasForeignKey(person => person.CompanyId);

        // Vinculo com Roles.
        builder.HasMany(company => company.Roles).WithOne(role => role.Company).HasForeignKey(role => role.CompanyId);
    }
}
