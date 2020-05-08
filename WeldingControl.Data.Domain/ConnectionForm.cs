using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class ConnectionForm
    {
        public ConnectionForm()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateConnectionForm>();
            WeldParams = new HashSet<WeldParams>();
            WeldingPositions = new HashSet<WeldingPosition>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<EmployeeCertificateConnectionForm> EmployeeCertificates { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }

        public virtual ICollection<WeldingPosition> WeldingPositions { get; set; }
    }
}