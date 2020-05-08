namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateConnectionForm
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int ConnectionFormId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public ConnectionForm ConnectionForm { get; set; }
    }
}