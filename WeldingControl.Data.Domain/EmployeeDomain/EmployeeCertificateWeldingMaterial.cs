namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateWeldingMaterial
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int WeldingMaterialId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public WeldingMaterial WeldingMaterial { get; set; }
    }
}