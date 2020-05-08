using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    public class WeldingTaskWelderConfiguration : IEntityTypeConfiguration<WeldingTaskWelder>
    {
        public void Configure(EntityTypeBuilder<WeldingTaskWelder> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 2);

            builder.Property(x => x.WelderId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.WeldingTaskId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Welder)
                .WithMany(x => x.WeldingTasks)
                .HasForeignKey(x => x.WelderId);

            builder.HasOne(x => x.WeldingTask)
                .WithMany(x => x.Welders)
                .HasForeignKey(x => x.WeldingTaskId);

            builder.HasData(new List<WeldingTaskWelder>
            {
                new WeldingTaskWelder
                {
                    Id = 1,
                    WelderId = 2,
                    WeldingTaskId = 1,
                }
            });
        }
    }
}