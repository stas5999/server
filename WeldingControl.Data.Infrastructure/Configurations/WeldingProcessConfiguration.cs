using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class WeldingProcessConfiguration : IEntityTypeConfiguration<WeldingProcess>
    {
        public void Configure(EntityTypeBuilder<WeldingProcess> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 12);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Description)
                
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Abbreviation)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<WeldingProcess>
            {
                new WeldingProcess
                {
                    Id = 1,
                    Code = 111,
                    Abbreviation = "SMAW",
                    Description = "Дуговая сварка плавящимся покрытым электродом"
                },
                new WeldingProcess
                {
                    Id = 2,
                    Code = 114,
                    Description = "Дуговая сварка порошковой проволокой"
                },
                new WeldingProcess
                {
                    Id = 3,
                    Code = 121,
                    Abbreviation = "SAW",
                    Description = "Дуговая сварка под флюсом проволочным электродом"
                },
                new WeldingProcess
                {
                    Id = 4,
                    Code = 131,
                    Abbreviation = "MIG",
                    Description = "Дуговая сварка в инертном газее плавящимся электродом"
                },
                new WeldingProcess
                {
                    Id = 5,
                    Code = 135,
                    Abbreviation = "MAG",
                    Description = "Дуговая сварка в инертном газее плавящимся электродом"
                },
                new WeldingProcess
                {
                    Id = 6,
                    Code = 136,
                    Description = "Дуговая сварка в активном газе порошковой проволокой"
                },
                new WeldingProcess
                {
                    Id = 7,
                    Code = 137,
                    Description = "Дуговая сварка в инертном газе порошковой проволокой"
                },
                new WeldingProcess
                {
                    Id = 8,
                    Code = 141,
                    Abbreviation = "TIG",
                    Description = "Дуговая сварка в инертном газе польфрамовым электродом"
                },
                new WeldingProcess
                {
                    Id = 9,
                    Code = 15,
                    Description = "Плазменная сварка"
                },
                new WeldingProcess
                {
                    Id = 10,
                    Code = 24,
                    Description = "Стыковая сварка оплавлением"
                },
                new WeldingProcess
                {
                    Id = 11,
                    Code = 311,
                    Description = "Ацетиленокислородная сварка"
                },
            });
        }
    }
}