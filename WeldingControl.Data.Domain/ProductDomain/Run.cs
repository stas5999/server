using System;
using System.Collections.Generic;
using WeldingControl.Data.Domain.EmployeeDomain;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class Run
    {
        public Run()
        {
            Measurements = new HashSet<Measurement>();
        }

        public int Id { get; set; }

        public int EmployeeWeldingTaskId { get; set; }

        public DateTime Date { get; set; }

        public DateTime WorkStart { get; set; }

        public int WorkTime { get; set; }

        public WeldingTaskWelder EmployeeWeldingTask { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}