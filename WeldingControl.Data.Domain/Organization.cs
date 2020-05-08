using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;
using WeldingControl.Data.Domain.ProductDomain;
using WeldingControl.Data.Domain.WeldingInstructionDomain;
using WeldingControl.Data.Domain.WeldingMachineDomain;

namespace WeldingControl.Data.Domain
{
    public class Organization
    {
        public Organization()
        {
            Employees = new HashSet<Employee>();
            Products = new HashSet<Product>();
            WeldingInstructions = new HashSet<WeldingInstruction>();
            WeldingMachines = new HashSet<WeldingMachine>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<WeldingInstruction> WeldingInstructions { get; set; }

        public virtual ICollection<WeldingMachine> WeldingMachines { get; set; }
    }
}