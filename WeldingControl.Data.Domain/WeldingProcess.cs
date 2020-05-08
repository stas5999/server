using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingMachineDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class WeldingProcess
    {
        public WeldingProcess()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateWeldingProcess>();
            WeldParams = new HashSet<WeldParams>();
            WeldingModes = new HashSet<WeldingMode>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingProcess> EmployeeCertificates { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }

        public virtual ICollection<WeldingMode> WeldingModes { get; set; }
    }
}