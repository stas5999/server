using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class EmployeeCertificateWeldTypeConfiguration : IEntityTypeConfiguration<EmployeeCertificateWeldType>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateWeldType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 7);

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldTypeId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.WeldTypes)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.WeldType)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.WeldTypeId);

            builder.HasData(new List<EmployeeCertificateWeldType>
            {
                new EmployeeCertificateWeldType
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    WeldTypeId = 1
                },
                new EmployeeCertificateWeldType
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    WeldTypeId = 2
                },
                new EmployeeCertificateWeldType
                {
                    Id = 3,
                    EmployeeCertificateId = 2,
                    WeldTypeId = 1
                },
                new EmployeeCertificateWeldType
                {
                    Id = 4,
                    EmployeeCertificateId = 2,
                    WeldTypeId = 2
                },
                new EmployeeCertificateWeldType
                {
                    Id = 5,
                    EmployeeCertificateId = 3,
                    WeldTypeId = 1
                },
                new EmployeeCertificateWeldType
                {
                    Id = 6,
                    EmployeeCertificateId = 3,
                    WeldTypeId = 2
                },
            });
        }
    }
}