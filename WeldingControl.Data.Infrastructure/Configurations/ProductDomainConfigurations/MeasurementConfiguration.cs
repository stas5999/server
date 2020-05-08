using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    internal class MeasurementConfiguration : IEntityTypeConfiguration<Measurement>
    {
        public void Configure(EntityTypeBuilder<Measurement> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Current)
                .IsRequired();

            builder.Property(x => x.Voltage)
                .IsRequired();

            builder.Property(x => x.RunId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Run)
                .WithMany(x => x.Measurements)
                .HasForeignKey(x => x.RunId);
        }
    }
}