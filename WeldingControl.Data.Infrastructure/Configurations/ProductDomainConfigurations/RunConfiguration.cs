using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Infrastructure.Configurations.ProductDomainConfigurations
{
    internal class RunConfiguration : IEntityTypeConfiguration<Run>
    {
        public void Configure(EntityTypeBuilder<Run> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd();

            builder.Property(x => x.EmployeeWeldingTaskId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.Date)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.WorkStart)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.WorkTime)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.EmployeeWeldingTask)
                .WithMany(x => x.Runs)
                .HasForeignKey(x => x.EmployeeWeldingTaskId);
        }
    }
}