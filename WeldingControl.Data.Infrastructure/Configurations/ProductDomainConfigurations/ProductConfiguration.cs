using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 3);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Description)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.CreationDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.OrganizationId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasData(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Code = "T24",
                    OrganizationId = 2,
                    CreationDate = new DateTime(2020,04,01),
                    Description = "Поперечная труба"
                },
                new Product
                {
                    Id = 2,
                    Code = "T51",
                    OrganizationId = 2,
                    CreationDate = new DateTime(2020,04,01),
                    Description = "Изогнутая труба"
                }
            });
        }
    }
}