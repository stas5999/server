using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class WeldType
    {
        public WeldType()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateWeldType>();
            WeldParams = new HashSet<WeldParams>();
            EmployeeCertificatesWeldingTechniqueWeldTypes = new HashSet<EmployeeCertificateWeldingTechnique>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public string Abbreviation { get; set; }

        public virtual ICollection<EmployeeCertificateWeldType> EmployeeCertificates { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingTechnique> EmployeeCertificatesWeldingTechniqueWeldTypes { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }
    }
}