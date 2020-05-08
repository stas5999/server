using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class FillerMaterialConfigurations : IEntityTypeConfiguration<FillerMaterial>
    {
        public void Configure(EntityTypeBuilder<FillerMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 9);

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Description)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<FillerMaterial>
            {
                new FillerMaterial
                {
                    Id = 1,
                    Abbreviation = "S",
                },
                new FillerMaterial
                {
                    Id = 2,
                    Abbreviation = "M",
                },
                new FillerMaterial
                {
                    Id = 3,
                    Abbreviation = "A",
                },
                new FillerMaterial
                {
                    Id = 4,
                    Abbreviation = "RA",
                },
                new FillerMaterial
                {
                    Id = 5,
                    Abbreviation = "RB",
                },
                new FillerMaterial
                {
                    Id = 6,
                    Abbreviation = "RC",
                },
                new FillerMaterial
                {
                    Id = 7,
                    Abbreviation = "RR",
                },
                new FillerMaterial
                {
                    Id = 8,
                    Abbreviation = "R",
                },
            });
        }
    }
}