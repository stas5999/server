using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.Utility;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class EmployeeCertificateConfiguration : IEntityTypeConfiguration<EmployeeCertificate>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 4);

            builder.Property(x => x.IssueDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.ExpiresDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.EmployeeId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.OwnsOne(x => x.Thickness)
                .HasData(new
                {
                    EmployeeCertificateId = 1,
                    Min = 3.0,
                    Max = 7.0,
                }, new
                {
                    EmployeeCertificateId = 2,
                    Min = 3.0,
                    Max = 9.0,
                }, new
                {
                    EmployeeCertificateId = 3,
                    Min = 3.0,
                    Max = 7.0,
                });
            builder.OwnsOne(x => x.PipeOuterDiameter)
                .HasData(new
                {
                    EmployeeCertificateId = 1,
                    Min = 28.5,
                }, new
                {
                    EmployeeCertificateId = 2,
                    Min = 28.5,
                }, new
                {
                    EmployeeCertificateId = 3,
                    Min = 28.5,
                });

            builder.Property(x => x.Decision)
                .HasMaxLength(10000)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.Certificates)
                .HasForeignKey(x => x.EmployeeId);

            builder.HasData(new List<EmployeeCertificate>
            {
                new EmployeeCertificate
                {
                    Id = 1,
                    IssueDate = new DateTime(2019,12,28),
                    ExpiresDate = new DateTime(2019,12,28).AddMonths(6),
                    EmployeeId = 2,
                    Decision = "Допушен к 141 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС",
                },
                new EmployeeCertificate
                {
                    Id = 2,
                    IssueDate = new DateTime(2019,12,28),
                    ExpiresDate = new DateTime(2019,12,28).AddMonths(6),
                    EmployeeId = 1,
                    Decision = "Допушен к 111 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС",
                },
                new EmployeeCertificate
                {
                    Id = 3,
                    IssueDate = new DateTime(2019,12,28),
                    ExpiresDate = new DateTime(2019,12,28).AddMonths(6),
                    EmployeeId = 3,
                    Decision = "Допушен к 141 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС",
                },
            });
        }
    }
}