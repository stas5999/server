using System.Collections.Generic;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class Weld
    {
        public Weld()
        {
            WeldingTasks = new HashSet<WeldingTask>();
        }

        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public virtual ICollection<WeldingTask> WeldingTasks { get; set; }
    }
}