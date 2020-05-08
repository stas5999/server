using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateWeldingMaterialConfiguration : IEntityTypeConfiguration<EmployeeCertificateWeldingMaterial>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateWeldingMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingMaterialId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.WeldingMaterials)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.WeldingMaterial)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.WeldingMaterialId);
        }
    }
}