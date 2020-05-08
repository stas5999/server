using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class ConnectionFormConfiguration : IEntityTypeConfiguration<ConnectionForm>
    {
        public void Configure(EntityTypeBuilder<ConnectionForm> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 4);

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<ConnectionForm>
            {
                new ConnectionForm
                {
                    Id = 1,
                    Abbreviation = "P",
                    Description = "Пластина",
                },
                new ConnectionForm
                {
                    Id = 2,
                    Abbreviation = "T",
                    Description = "Труба",
                },
                new ConnectionForm
                {
                    Id = 3,
                    Abbreviation = "Rb",
                    Description = "Стержень",
                },
            });
        }
    }
}