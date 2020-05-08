using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class WeldingMaterialConfiguration : IEntityTypeConfiguration<WeldingMaterial>
    {
        public void Configure(EntityTypeBuilder<WeldingMaterial> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());
        }
    }
}