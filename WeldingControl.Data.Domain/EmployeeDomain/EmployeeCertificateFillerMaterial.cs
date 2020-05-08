namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateFillerMaterial
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int FillerMaterialId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public FillerMaterial FillerMaterial { get; set; }
    }
}