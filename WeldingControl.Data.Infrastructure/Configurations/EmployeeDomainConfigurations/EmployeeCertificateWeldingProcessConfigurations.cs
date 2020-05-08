using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateWeldingProcessConfigurations : IEntityTypeConfiguration<EmployeeCertificateWeldingProcess>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateWeldingProcess> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 4);

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingProcessId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.WeldingProcesses)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.Process)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.WeldingProcessId);

            builder.HasData(new List<EmployeeCertificateWeldingProcess>
            {
                new EmployeeCertificateWeldingProcess
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    WeldingProcessId = 8,
                },
                new EmployeeCertificateWeldingProcess
                {
                    Id = 2,
                    EmployeeCertificateId = 2,
                    WeldingProcessId = 1,
                },
                new EmployeeCertificateWeldingProcess
                {
                    Id = 3,
                    EmployeeCertificateId = 3,
                    WeldingProcessId = 8,
                }
            });
        }
    }
}