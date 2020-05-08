namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateWeldingTechnique
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int WeldingTechniqueId { get; set; }

        public int WeldTypeId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public WeldingTechnique WeldingTechnique { get; set; }

        public WeldType WeldType { get; set; }
    }
}