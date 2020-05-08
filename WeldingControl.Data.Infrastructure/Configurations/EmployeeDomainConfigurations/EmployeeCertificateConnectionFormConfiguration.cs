using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateConnectionFormConfiguration : IEntityTypeConfiguration<EmployeeCertificateConnectionForm>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateConnectionForm> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 7);

            builder.Property(x => x.EmployeeCertificateId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.Property(x => x.ConnectionFormId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.ConnectionForms)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.ConnectionForm)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.ConnectionFormId);

            builder.HasData(new List<EmployeeCertificateConnectionForm>
            {
                new EmployeeCertificateConnectionForm
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    ConnectionFormId = 1
                },
                new EmployeeCertificateConnectionForm
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    ConnectionFormId = 2
                },
                new EmployeeCertificateConnectionForm
                {
                    Id = 3,
                    EmployeeCertificateId = 2,
                    ConnectionFormId = 1
                },
                new EmployeeCertificateConnectionForm
                {
                    Id = 4,
                    EmployeeCertificateId = 2,
                    ConnectionFormId = 2
                },
                new EmployeeCertificateConnectionForm
                {
                    Id = 5,
                    EmployeeCertificateId = 3,
                    ConnectionFormId = 1
                },
                new EmployeeCertificateConnectionForm
                {
                    Id = 6,
                    EmployeeCertificateId = 3,
                    ConnectionFormId = 2
                },
            });
        }
    }
}