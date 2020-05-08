using System;
using System.Collections.Generic;
using WeldingControl.Data.Domain.ProductDomain;
using WeldingControl.Shared.Constants.Enums;

namespace WeldingControl.Data.Domain.EmployeeDomain
{
    public class Employee
    {
        public Employee()
        {
            Certificates = new HashSet<EmployeeCertificate>();
            CreatedWeldingTasks = new HashSet<WeldingTask>();
            WeldingTasks = new HashSet<WeldingTaskWelder>();
        }

        public int Id { get; set; }

        public Position Position { get; set; }

        public DateTime EmploymentDate { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Stamp { get; set; }

        public string Identification { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public virtual ICollection<EmployeeCertificate> Certificates { get; set; }

        public virtual ICollection<WeldingTask> CreatedWeldingTasks { get; set; }

        public virtual ICollection<WeldingTaskWelder> WeldingTasks { get; set; }
    }
}