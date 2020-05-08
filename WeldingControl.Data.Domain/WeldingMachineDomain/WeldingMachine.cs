using System.Collections.Generic;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Domain.WeldingMachineDomain
{
    public class WeldingMachine
    {
        public WeldingMachine()
        {
            Modes = new HashSet<WeldingMode>();
            WeldingTasks = new HashSet<WeldingTask>();
        }

        public int Id { get; set; }

        public string Identification { get; set; }

        public int OrganizationId { get; set; }

        public int RecorderId { get; set; }

        public Organization Organization { get; set; }

        public Recorder Recorder { get; set; }

        public virtual ICollection<WeldingMode> Modes { get; set; }

        public virtual ICollection<WeldingTask> WeldingTasks { get; set; }
    }
}