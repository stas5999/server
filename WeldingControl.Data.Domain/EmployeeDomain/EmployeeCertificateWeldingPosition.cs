namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateWeldingPosition
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int WeldingPositionId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public WeldingPosition WeldingPosition { get; set; }
    }
}