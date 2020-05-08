namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateAdditionalMaterial
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int AdditionalMaterialId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public AdditionalMaterial AdditionalMaterial { get; set; }
    }
}