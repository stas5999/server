using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;

namespace WeldingControl.Data.Domain
{
    public class MainMaterial
    {
        public MainMaterial()
        {
            EmployeeCertificates = new HashSet<EmployeeCertificateMainMaterial>();
            WeldParams = new HashSet<WeldParams>();
        }

        public int Id { get; set; }

        public int Group { get; set; }

        public int SubGroup { get; set; }

        public string Description { get; set; }

        public virtual ICollection<EmployeeCertificateMainMaterial> EmployeeCertificates { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }
    }
}