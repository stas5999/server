using System;
using System.Collections.Generic;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class Product
    {
        public Product()
        {
            Welds = new HashSet<Weld>();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public virtual ICollection<Weld> Welds { get; set; }
    }
}