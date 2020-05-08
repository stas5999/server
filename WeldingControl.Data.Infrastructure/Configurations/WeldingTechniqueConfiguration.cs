using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class WeldingTechniqueConfiguration : IEntityTypeConfiguration<WeldingTechnique>
    {
        public void Configure(EntityTypeBuilder<WeldingTechnique> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 8);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<WeldingTechnique>
            {
                new WeldingTechnique
                {
                    Id = 1,
                    Abbreviation = "bs",
                    Description = "Двухсторонняя сварка",
                },
                new WeldingTechnique
                {
                    Id = 2,
                    Abbreviation = "lw,rw",
                    Description = "Сварка левым способом, сварка правым способом",
                },
                new WeldingTechnique
                {
                    Id = 3,
                    Abbreviation = "mb",
                    Description = "Сварка с защитой сварочной ванны",
                },
                new WeldingTechnique
                {
                    Id = 4,
                    Abbreviation = "ml",
                    Description = "Многослойная сварка",
                },
                new WeldingTechnique
                {
                    Id = 5,
                    Abbreviation = "nb",
                    Description = "Сварка без защиты сварочной ванны",
                },
                new WeldingTechnique
                {
                    Id = 6,
                    Abbreviation = "ss",
                    Description = "Односторонняя сварка",
                },
                new WeldingTechnique
                {
                    Id = 7,
                    Abbreviation = "sl",
                    Description = "Однослойная сварка",
                },
            });
        }
    }
}