namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateWeldingProcess
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int WeldingProcessId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public WeldingProcess Process { get; set; }
    }
}