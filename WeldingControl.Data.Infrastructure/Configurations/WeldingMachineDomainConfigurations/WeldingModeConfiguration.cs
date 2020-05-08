using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.Utility;
using WeldingControl.Data.Domain.WeldingMachineDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.WeldingMachineDomainConfigurations
{
    internal class WeldingModeConfiguration : IEntityTypeConfiguration<WeldingMode>
    {
        public void Configure(EntityTypeBuilder<WeldingMode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.OwnsOne(x => x.Current)
                .HasData(new
                {
                    WeldingModeId = 1,
                    Min = 0.0,
                    Max = 500.0,
                }); ;

            builder.Property(x => x.EquipmentId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingProcessId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.WeldingMachine)
                .WithMany(x => x.Modes)
                .HasForeignKey(x => x.EquipmentId);

            builder.HasOne(x => x.WeldingProcess)
                .WithMany(x => x.WeldingModes)
                .HasForeignKey(x => x.WeldingProcessId);

            builder.HasData(new List<WeldingMode>
            {
                new WeldingMode
                {
                    Id = 1,
                    EquipmentId = 1,
                    WeldingProcessId = 1,
                }
            });
        }
    }
}