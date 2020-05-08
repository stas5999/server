using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class WeldingPosition
    {
        public WeldingPosition()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateWeldingPosition>();
            WeldParams = new HashSet<WeldParams>();
        }

        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int ConnectionFormId { get; set; }

        public ConnectionForm ConnectionForm { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingPosition> EmployeeCertificates { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }
    }
}