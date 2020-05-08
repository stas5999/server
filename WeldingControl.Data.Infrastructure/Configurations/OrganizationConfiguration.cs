using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 3);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<Organization>
            {
                new Organization
                {
                    Id = 1,
                    Name = "ООО \"Протос\"",
                },
                new Organization
                {
                    Id = 2,
                    Name = "Филиал ММУ-1 ОАО \"Могилевтехмонтаж\""
                }
            });
        }
    }
}