using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateWeldingPositionConfiguration : IEntityTypeConfiguration<EmployeeCertificateWeldingPosition>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateWeldingPosition> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 22);

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingPositionId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.WeldingPositions)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.WeldingPosition)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.WeldingPositionId);

            builder.HasData(new List<EmployeeCertificateWeldingPosition>
            {
                new EmployeeCertificateWeldingPosition
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 1,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 5,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 3,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 2,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 4,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 6,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 5,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 4,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 6,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 8,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 7,
                    EmployeeCertificateId = 1,
                    WeldingPositionId = 10,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 8,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 1,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 9,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 5,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 10,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 2,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 11,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 6,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 12,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 4,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 13,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 8,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 14,
                    EmployeeCertificateId = 2,
                    WeldingPositionId = 10,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 15,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 1,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 16,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 5,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 17,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 2,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 18,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 6,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 19,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 4,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 20,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 8,
                },
                new EmployeeCertificateWeldingPosition
                {
                    Id = 21,
                    EmployeeCertificateId = 3,
                    WeldingPositionId = 10,
                },
            });
        }
    }
}