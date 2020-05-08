using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    public class WeldConfiguration : IEntityTypeConfiguration<Weld>
    {
        public void Configure(EntityTypeBuilder<Weld> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.ProductId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Welds)
                .HasForeignKey(x => x.ProductId);

            builder.HasData(new List<Weld>
            {
                new Weld
                {
                    Id = 1,
                    ProductId = 1
                }
            });
        }
    }
}