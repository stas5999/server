using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.WeldingInstructionDomainConfiguration
{
    internal class WeldParamsConfiguration : IEntityTypeConfiguration<WeldParams>
    {
        public void Configure(EntityTypeBuilder<WeldParams> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.OwnsOne(x => x.Current)
                .HasData(new
                {
                    WeldParamsId = 1,
                    Min = 0.0,
                    Max = 500.0,
                });

            builder.OwnsOne(x => x.Thickness)
                .HasData(new
                {
                    WeldParamsId = 1,
                    Min = 6.0,
                    Max = 6.0,
                });

            builder.OwnsOne(x => x.PipeOuterDiameter)
                .HasData(new
                {
                    WeldParamsId = 1,
                    Min = 40.0,
                    Max = 40.0,
                });

            builder.Property(x => x.WeldingProcessId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.ConnectionFormId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldTypeId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.MainMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.FillerMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.ShieldingGasId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.AdditionalMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingPositionId)
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingInstructionId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.WeldingProcess)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.WeldingProcessId);

            builder.HasOne(x => x.ConnectionForm)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.ConnectionFormId);

            builder.HasOne(x => x.WeldType)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.WeldTypeId);

            builder.HasOne(x => x.MainMaterial)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.MainMaterialId);

            builder.HasOne(x => x.FillerMaterial)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.FillerMaterialId);

            builder.HasOne(x => x.ShieldingGas)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.ShieldingGasId);

            builder.HasOne(x => x.WeldingMaterial)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.WeldingMaterialId);

            builder.HasOne(x => x.AdditionalMaterial)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.AdditionalMaterialId);

            builder.HasOne(x => x.WeldingPosition)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.WeldingPositionId);

            builder.HasOne(x => x.WeldingInstruction)
                .WithMany(x => x.WeldParams)
                .HasForeignKey(x => x.WeldingInstructionId);

            builder.HasData(new List<WeldParams>
            {
                new WeldParams
                {
                    Id = 1,
                    WeldingInstructionId = 1,
                    ConnectionFormId = 2,
                    WeldingPositionId = 1,
                    MainMaterialId = 1,
                    WeldingProcessId = 1,
                    WeldTypeId = 1,
                }
            });
        }
    }
}