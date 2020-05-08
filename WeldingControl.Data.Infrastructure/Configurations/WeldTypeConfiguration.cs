using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class WeldTypeConfiguration : IEntityTypeConfiguration<WeldType>
    {
        public void Configure(EntityTypeBuilder<WeldType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 3);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<WeldType>
            {
                new WeldType
                {
                    Id = 1,
                    Abbreviation = "BW",
                    Description = "Стыковой шов",
                },
                new WeldType
                {
                    Id = 2,
                    Abbreviation = "FW",
                    Description = "Угловой шов",
                },
            });
        }
    }
}