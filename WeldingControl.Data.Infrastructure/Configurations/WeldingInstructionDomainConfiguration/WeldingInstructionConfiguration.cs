using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.WeldingInstructionDomainConfiguration
{
    internal class WeldingInstructionConfiguration : IEntityTypeConfiguration<WeldingInstruction>
    {
        public void Configure(EntityTypeBuilder<WeldingInstruction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.CreationDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.OrganizationId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.WeldingInstructions)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasData(new List<WeldingInstruction>
            {
                new WeldingInstruction
                {
                    Id = 1,
                    CreationDate = new DateTime(2019,11,09),
                    OrganizationId = 2,
                }
            });
        }
    }
}