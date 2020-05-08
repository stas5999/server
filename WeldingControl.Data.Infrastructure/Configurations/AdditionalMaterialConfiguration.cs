using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain;

namespace WeldingControl.Data.Infrastructure.Configurations
{
    internal class AdditionalMaterialConfiguration : IEntityTypeConfiguration<AdditionalMaterial>
    {
        public void Configure(EntityTypeBuilder<AdditionalMaterial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Abbreviation)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());
        }
    }
}