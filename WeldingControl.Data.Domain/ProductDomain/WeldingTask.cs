using System;
using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;
using WeldingControl.Data.Domain.WeldingMachineDomain;
using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class WeldingTask
    {
        public WeldingTask()
        {
            Welders = new HashSet<WeldingTaskWelder>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public WeldingTaskStatus Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public int WeldId { get; set; }

        public int EquipmentId { get; set; }

        public int WeldingInstructionId { get; set; }

        public int MasterId { get; set; } 

        public Weld Weld { get; set; }

        public WeldingMachine WeldingMachine { get; set; }

        public WeldingInstruction WeldingInstruction { get; set; }

        public Employee Master { get; set; }

        public virtual ICollection<WeldingTaskWelder> Welders { get; set; }
    }
}