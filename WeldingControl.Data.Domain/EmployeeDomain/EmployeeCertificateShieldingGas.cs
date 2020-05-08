namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificateShieldingGas
    {
        public int Id { get; set; }

        public int EmployeeCertificateId { get; set; }

        public int ShieldingGasId { get; set; }

        public EmployeeCertificate Certificate { get; set; }

        public ShieldingGas ShieldingGas { get; set; }
    }
}