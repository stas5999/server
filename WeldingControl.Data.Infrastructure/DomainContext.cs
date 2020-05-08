using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using WeldingControl.Data.Domain;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.ProductDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;
using WeldingControl.Data.Domain.WeldingMachineDomain;

namespace WeldingControl.Data.Infrastructure
{
    public class DomainContext : DbContext
    {
        public DomainContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }

        public DbSet<EmployeeCertificateAdditionalMaterial> EmployeeCertificateAdditionalMaterials { get; set; }

        public DbSet<EmployeeCertificateConnectionForm> EmployeeCertificateConnectionForms { get; set; }

        public DbSet<EmployeeCertificateFillerMaterial> EmployeeCertificateFillerMaterials { get; set; }

        public DbSet<EmployeeCertificateMainMaterial> EmployeeCertificateMainMaterials { get; set; }

        public DbSet<EmployeeCertificateShieldingGas> EmployeeCertificateShieldingGases { get; set; }

        public DbSet<EmployeeCertificateWeldingMaterial> EmployeeCertificateWeldingMaterials { get; set; }

        public DbSet<EmployeeCertificateWeldingPosition> EmployeeCertificateWeldingPositions { get; set; }

        public DbSet<EmployeeCertificateWeldingProcess> EmployeeCertificateWeldingProcesses { get; set; }

        public DbSet<EmployeeCertificateWeldingTechnique> EmployeeCertificateWeldingTechniques { get; set; }

        public DbSet<EmployeeCertificateWeldType> EmployeeCertificateWeldTypes { get; set; }

        public DbSet<Measurement> Measurements { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<Weld> Welds { get; set; }

        public DbSet<WeldingTask> WeldingTasks { get; set; }

        public DbSet<WeldingTaskWelder> WeldingTaskWelders { get; set; }

        public DbSet<WeldingInstruction> WeldingInstructions { get; set; }

        public DbSet<WeldParams> WeldParams { get; set; }

        public DbSet<Recorder> Recorders { get; set; }

        public DbSet<WeldingMachine> WeldingMachines { get; set; }

        public DbSet<WeldingMode> WeldingModes { get; set; }

        public DbSet<AdditionalMaterial> AdditionalMaterials { get; set; }

        public DbSet<ConnectionForm> ConnectionForms { get; set; }

        public DbSet<FillerMaterial> FillerMaterials { get; set; }

        public DbSet<MainMaterial> MainMaterials { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<ShieldingGas> ShieldingGases { get; set; }

        public DbSet<WeldingMaterial> WeldingMaterials { get; set; }

        public DbSet<WeldingPosition> WeldingPositions { get; set; }

        public DbSet<WeldingProcess> WeldingProcesses { get; set; }

        public DbSet<WeldingTechnique> WeldingTechniques { get; set; }

        public DbSet<WeldType> WeldTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityByDefaultColumns();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.HasPostgresExtension("citext");
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.SetTableName(ToSnakeCase(entity.GetTableName()));

                // Replace column names            
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(ToSnakeCase(property.GetColumnName()));
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(ToSnakeCase(key.GetName()));
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.SetConstraintName(ToSnakeCase(key.GetConstraintName()));
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetName(ToSnakeCase(index.GetName()));
                }
            }
        }

        public static string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) { return input; }

            var startUnderscores = Regex.Match(input, @"^_+");
            return startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}