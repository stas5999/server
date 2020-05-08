using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.WeldingMachineDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.WeldingMachineDomainConfigurations
{
    public class RecorderConfiguration : IEntityTypeConfiguration<Recorder>
    {
        public void Configure(EntityTypeBuilder<Recorder> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.Identifier)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.HasData(new List<Recorder>
            {
                new Recorder
                {
                    Id = 1,
                    Identifier = "00001"
                }
            });
        }
    }
}