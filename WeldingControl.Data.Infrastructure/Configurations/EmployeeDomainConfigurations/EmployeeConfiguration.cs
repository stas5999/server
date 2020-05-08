using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Data.Infrastructure.Configurations.EmployeeDomainConfigurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnType(NpgsqlDbType.Integer.ToString())
                .ValueGeneratedOnAdd()
                .HasIdentityOptions(startValue: 5);

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Position)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.Property(x => x.EmploymentDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.MiddleName)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.BirthDate)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Date.ToString());

            builder.Property(x => x.Stamp)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.Identification)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Varchar.ToString());

            builder.Property(x => x.OrganizationId)
                .IsRequired()
                .HasColumnType(NpgsqlDbType.Integer.ToString());

            builder.HasOne(x => x.Organization)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.OrganizationId);

            builder.HasIndex(x => x.UserName)
                .IsUnique();

            builder.HasData(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    UserName = "dgoncharov",
                    FirstName = "Денис",
                    LastName = "Гончаров",
                    MiddleName = "Геннадьевич",
                    BirthDate = new DateTime(1992,08,31),
                    OrganizationId = 2,
                    Stamp = "22",
                    Identification = "КВ 2291021",
                    Position = Position.Welder,
                    EmploymentDate = new DateTime(2012,03,14),
                },
                new Employee
                {
                    Id = 2,
                    UserName = "alozikov",
                    FirstName = "Александр",
                    LastName = "Лозиков",
                    MiddleName = "Евгеньевич",
                    BirthDate = new DateTime(1986,07,28),
                    OrganizationId = 2,
                    Stamp = "Л4",
                    Identification = "КВ 1789243",
                    Position = Position.Welder,
                    EmploymentDate = new DateTime(2007,08,19),
                },
                new Employee
                {
                    Id = 3,
                    UserName = "apusovsky",
                    FirstName = "Алексей",
                    LastName = "Пусовский",
                    MiddleName = "Иванович",
                    BirthDate = new DateTime(1988,03,15),
                    OrganizationId = 2,
                    Stamp = "П8",
                    Identification = "КВ 1993091",
                    Position = Position.Welder,
                    EmploymentDate = new DateTime(2006,11,21),
                },
                new Employee
                {
                    Id = 4,
                    UserName = "szaichenko",
                    FirstName = "Семен",
                    LastName = "Зайченко",
                    MiddleName = "Сергеевич",
                    BirthDate = new DateTime(1990,01,12),
                    OrganizationId = 2,
                    Stamp = "22",
                    Identification = "КВ 1845912",
                    Position = Position.Master,
                    EmploymentDate = new DateTime(2009,01,22),
                },
            });
        }
    }
}