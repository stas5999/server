using WeldingControl.Shared.Constants.Enums;
using WeldingControl.Data.Domain.EmployeeDomain;
using System;
using WeldingControl.Data.Domain.Utility;
using System.Collections.Generic;

namespace WeldingControl.Business.Core.Employees.Queries.GetCertificates
{
    public class CertificatesDto
    {
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpiresDate { get; set; }

        public int EmployeeId { get; set; }

        public Param Thickness { get; set; }

        public Param PipeOuterDiameter { get; set; }

        public string Decision { get; set; }

        public Employee Employee { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingProcess> WeldingProcesses { get; set; }

        public virtual ICollection<EmployeeCertificateConnectionForm> ConnectionForms { get; set; }

        public virtual ICollection<EmployeeCertificateWeldType> WeldTypes { get; set; }

        public virtual ICollection<EmployeeCertificateMainMaterial> MainMaterials { get; set; }

        public virtual ICollection<EmployeeCertificateFillerMaterial> FillerMaterials { get; set; }

        public virtual ICollection<EmployeeCertificateShieldingGas> ShieldingGases { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingMaterial> WeldingMaterials { get; set; }

        public virtual ICollection<EmployeeCertificateAdditionalMaterial> AdditionalMaterials { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingPosition> WeldingPositions { get; set; }

        public virtual ICollection<EmployeeCertificateWeldingTechnique> WeldingTechniques { get; set; }
    }
}
