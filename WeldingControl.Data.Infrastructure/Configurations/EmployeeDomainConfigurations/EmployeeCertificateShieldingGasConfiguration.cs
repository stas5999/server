using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class
        EmployeeCertificateShieldingGasConfiguration : IEntityTypeConfiguration<EmployeeCertificateShieldingGas>
    {
        public void Configure(EntityTypeBuilder<EmployeeCertificateShieldingGas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.EmployeeCertificateId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.ShieldingGasId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Certificate)
                .WithMany(x => x.ShieldingGases)
                .HasForeignKey(x => x.EmployeeCertificateId);

            builder.HasOne(x => x.ShieldingGas)
                .WithMany(x => x.EmployeeCertificates)
                .HasForeignKey(x => x.ShieldingGasId);
        }
    }
}