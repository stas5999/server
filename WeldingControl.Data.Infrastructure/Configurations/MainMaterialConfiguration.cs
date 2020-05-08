using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class MainMaterialConfiguration : IEntityTypeConfiguration<MainMaterial>
    {
        public void Configure(EntityTypeBuilder<MainMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 4);

            builder.Property(x => x.Group)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.SubGroup)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<MainMaterial>
            {
                new MainMaterial
                {
                    Id = 1,
                    Description = "Стали с установленным минимальным пределом текучести (до 275)",
                    Group = 1,
                    SubGroup = 1
                },
                new MainMaterial
                {
                    Id = 2,
                    Description = "Стали с установленным минимальным пределом текучести (от 275 до 360)",
                    Group = 1,
                    SubGroup = 4
                },
                new MainMaterial
                {
                    Id = 3,
                    Description = "Стали с улучшенной коррозионной стойкостью по отношению к кислороду",
                    Group = 1,
                    SubGroup = 4
                },
            });
        }
    }
}