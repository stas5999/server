using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateFillerMaterialConfiguration : IEntityTypeConfiguration<EmployeeCertificateFillerMaterial>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateFillerMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 11);

            builder.Property(x => x.EmployeeCertificateId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.Property(x => x.FillerMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.FillerMaterials)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.FillerMaterial)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.FillerMaterialId);

            builder.HasData(new List<EmployeeCertificateFillerMaterial>
            {
                new EmployeeCertificateFillerMaterial
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    FillerMaterialId = 1
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    FillerMaterialId = 2
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 3,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 3,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 4,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 4,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 5,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 5,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 6,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 6,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 7,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 7,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 8,
                    EmployeeCertificateId = 2,
                    FillerMaterialId = 8,
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 9,
                    EmployeeCertificateId = 3,
                    FillerMaterialId = 1
                },
                new EmployeeCertificateFillerMaterial
                {
                    Id = 10,
                    EmployeeCertificateId = 3,
                    FillerMaterialId = 2
                },
            });
        }
    }
}