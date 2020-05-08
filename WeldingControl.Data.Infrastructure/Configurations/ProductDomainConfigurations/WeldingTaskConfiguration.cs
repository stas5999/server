using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;
using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    internal class WeldingTaskConfiguration : IEntityTypeConfiguration<WeldingTask>
    {
        public void Configure(EntityTypeBuilder<WeldingTask> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.Description)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.CreationDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.CompletionDate)
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.WeldId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.EquipmentId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingInstructionId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.MasterId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Weld)
                .WithMany(x => x.WeldingTasks)
                .HasForeignKey(x => x.WeldId);

            builder.HasOne(x => x.WeldingMachine)
                .WithMany(x => x.WeldingTasks)
                .HasForeignKey(x => x.EquipmentId);

            builder.HasOne(x => x.WeldingInstruction)
                .WithMany(x => x.WeldingTasks)
                .HasForeignKey(x => x.WeldingInstructionId);

            builder.HasOne(x => x.Master)
                .WithMany(x => x.CreatedWeldingTasks)
                .HasForeignKey(x => x.MasterId);

            builder.HasData(new List<WeldingTask>
            {
                new WeldingTask
                {
                    Id = 1,
                    Description = "Выполнить сварку поперечной трубы",
                    CreationDate = new DateTime(2020,04,15),
                    EquipmentId = 1,
                    MasterId = 4,
                    WeldingInstructionId = 1,
                    Status = WeldingTaskStatus.Created,
                    WeldId = 1
                }
            });
        }
    }
}