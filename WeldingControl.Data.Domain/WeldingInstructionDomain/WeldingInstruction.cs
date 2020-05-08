using System;
using System.Collections.Generic;
using WeldingControl.Data.Domain.ProductDomain;

namespace WeldingControl.Data.Domain.WeldingInstructionDomain
{
    public class WeldingInstruction
    {
        public WeldingInstruction()
        {
            WeldParams = new HashSet<WeldParams>();
            WeldingTasks = new HashSet<WeldingTask>();
        }

        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public virtual ICollection<WeldParams> WeldParams { get; set; }

        public virtual ICollection<WeldingTask> WeldingTasks { get; set; }
    }
}