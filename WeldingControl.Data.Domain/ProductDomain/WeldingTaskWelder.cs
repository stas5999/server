using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class WeldingTaskWelder
    {
        public WeldingTaskWelder()
        {
            Runs = new HashSet<Run>();
        }

        public int Id { get; set; }

        public int WelderId { get; set; }

        public int WeldingTaskId { get; set; }

        public Employee Welder { get; set; }

        public WeldingTask WeldingTask { get; set; }

        public virtual ICollection<Run> Runs { get; set; }
    }
}