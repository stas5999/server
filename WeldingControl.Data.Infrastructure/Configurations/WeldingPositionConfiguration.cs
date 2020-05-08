using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class WeldingPositionConfiguration : IEntityTypeConfiguration<WeldingPosition>
    {
        public void Configure(EntityTypeBuilder<WeldingPosition> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 13);

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Code)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());


            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());


            builder.Property(x => x.ConnectionFormId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.ConnectionForm)
                .WithMany(x => x.WeldingPositions)
                .HasForeignKey(x => x.ConnectionFormId);

            builder.HasData(new List<WeldingPosition>
            {
                new WeldingPosition
                {
                    Id = 1,
                    Code = "С1, У1-1",
                    Abbreviation = "PA",
                    Description = "Нижнее стыковой и в \"лодочку\"",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 2,
                    Code = "С3",
                    Abbreviation = "PC",
                    Description = "Горизонтальное стыковое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 3,
                    Code = "С2-1, У2-1",
                    Abbreviation = "PF",
                    Description = "Вертикольное снизу вверх стыковое, тавровое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 4,
                    Code = "С4",
                    Abbreviation = "PE",
                    Description = "Потолочное стыковое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 5,
                    Code = "У1-2",
                    Abbreviation = "PB",
                    Description = "Нижнее тавровое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 6,
                    Code = "У4-2",
                    Abbreviation = "PD",
                    Description = "Потолочное тавровое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 7,
                    Code = "С1, У2-1",
                    Abbreviation = "PA",
                    Description = "Нижнее стыковой и в \"угол\" (труба поворотная)",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 8,
                    Code = "С5-1, У5-1",
                    Abbreviation = "PF",
                    Description = "Вертикольное снизу вверх стыковое, тавровое - труба неповоротнпя",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 9,
                    Code = "С3",
                    Abbreviation = "PC",
                    Description = "Горизонтальное стыковое",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 10,
                    Abbreviation = "H-L045",
                    Description = "наклонное под углом от 10 до 45 - труба неповоротная (сварка снизу вверх)",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 11,
                    Code = "У1-2-1",
                    Abbreviation = "PB",
                    Description = "Нижнее \"в угол\"",
                    ConnectionFormId = 1
                },
                new WeldingPosition
                {
                    Id = 12,
                    Code = "У4-2",
                    Abbreviation = "PD",
                    Description = "Потолочное \"в угол\"",
                    ConnectionFormId = 1
                },
            });
        }
    }
}