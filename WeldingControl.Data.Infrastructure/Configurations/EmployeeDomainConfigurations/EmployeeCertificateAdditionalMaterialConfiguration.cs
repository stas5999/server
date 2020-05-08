using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateAdditionalMaterialConfiguration : IEntityTypeConfiguration<
            EmployeeCertificateAdditionalMaterial>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateAdditionalMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.AdditionalMaterials)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.AdditionalMaterial)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.AdditionalMaterialId);
        }
    }
}