using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.WeldingMachineDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.WeldingMachineDomainConfigurations
{
    internal class WeldingMachineConfiguration : IEntityTypeConfiguration<WeldingMachine>
    {
        public void Configure(EntityTypeBuilder<WeldingMachine> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.Identification)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.OrganizationId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.RecorderId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.WeldingMachines)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasData(new List<WeldingMachine>
            {
                new WeldingMachine
                {
                    Id = 1,
                    Identification = "KZ103492 (984)",
                    OrganizationId = 2,
                    RecorderId = 1,
                }
            });
        }
    }
}