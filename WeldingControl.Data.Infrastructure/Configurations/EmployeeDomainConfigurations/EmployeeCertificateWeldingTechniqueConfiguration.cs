using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateWeldingTechniqueConfiguration : IEntityTypeConfiguration<EmployeeCertificateWeldingTechnique>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateWeldingTechnique> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 19);

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingTechniqueId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldTypeId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.WeldingTechniques)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.WeldingTechnique)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.WeldingTechniqueId);

            builder.HasOne(x => x.WeldType)
                .WithMany(x => x.EmployeeCertificatesWeldingTechniqueWeldTypes)
                .HasForeignKey(x => x.WeldTypeId);

            builder.HasData(new List<EmployeeCertificateWeldingTechnique>
            {
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 1,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 6,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 2,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 3,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 3,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 5,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 4,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 1,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 5,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 7,
                    WeldTypeId = 2,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 6,
                    EmployeeCertificateId = 1,
                    WeldingTechniqueId = 4,
                    WeldTypeId = 2,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 7,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 6,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 8,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 3,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 9,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 5,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 10,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 1,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 11,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 7,
                    WeldTypeId = 2,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 12,
                    EmployeeCertificateId = 2,
                    WeldingTechniqueId = 4,
                    WeldTypeId = 2,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 13,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 6,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 14,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 3,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 15,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 5,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 16,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 1,
                    WeldTypeId = 1,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 17,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 7,
                    WeldTypeId = 2,
                },
                new EmployeeCertificateWeldingTechnique
                {
                    Id = 18,
                    EmployeeCertificateId = 3,
                    WeldingTechniqueId = 4,
                    WeldTypeId = 2,
                },
            });
        }
    }
}