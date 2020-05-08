using System;
using System.Collections.Generic;
using WeldingControl.Data.Domain.Utility;

namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class EmployeeCertificate
    {
        public EmployeeCertificate()
        {
            WeldingProcesses = new HashSet<EmployeeCertificateWeldingProcess>();
            ConnectionForms = new HashSet<EmployeeCertificateConnectionForm>();
            WeldTypes = new HashSet<EmployeeCertificateWeldType>();
            MainMaterials = new HashSet<EmployeeCertificateMainMaterial>();
            FillerMaterials = new HashSet<EmployeeCertificateFillerMaterial>();
            ShieldingGases = new HashSet<EmployeeCertificateShieldingGas>();
            WeldingMaterials = new HashSet<EmployeeCertificateWeldingMaterial>();
            AdditionalMaterials = new HashSet<EmployeeCertificateAdditionalMaterial>();
            WeldingPositions = new HashSet<EmployeeCertificateWeldingPosition>();
        }

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