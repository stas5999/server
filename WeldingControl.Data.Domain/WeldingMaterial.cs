using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class WeldingMaterial
    {
        public WeldingMaterial()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateWeldingMaterial>();
            WeldParams = new HashSet<WeldParams>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingMaterial> EmployeeCertificates { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }
    }
}