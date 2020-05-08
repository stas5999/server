namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateMainMaterial
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int MainMaterialId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public MainMaterial MainMaterial { get; set; }
    }
}