using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateMainMaterialConfiguration : IEntityTypeConfiguration<EmployeeCertificateMainMaterial>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateMainMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 10);

            builder.Property(x => x.EmployeeCertificateId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.Property(x => x.MainMaterialId)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .IsRequired();

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.MainMaterials)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.MainMaterial)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.MainMaterialId);

            builder.HasData(new List<EmployeeCertificateMainMaterial>
            {
                new EmployeeCertificateMainMaterial
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    MainMaterialId = 1
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    MainMaterialId = 2
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 3,
                    EmployeeCertificateId = 1,
                    MainMaterialId = 3
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 4,
                    EmployeeCertificateId = 2,
                    MainMaterialId = 1
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 5,
                    EmployeeCertificateId = 2,
                    MainMaterialId = 2
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 6,
                    EmployeeCertificateId = 2,
                    MainMaterialId = 3
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 7,
                    EmployeeCertificateId = 3,
                    MainMaterialId = 1
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 8,
                    EmployeeCertificateId = 3,
                    MainMaterialId = 2
                },
                new EmployeeCertificateMainMaterial
                {
                    Id = 9,
                    EmployeeCertificateId = 3,
                    MainMaterialId = 3
                },
            });
        }
    }
}