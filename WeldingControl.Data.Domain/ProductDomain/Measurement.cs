using System;

namespace WeldingControl.Data.Domain.ProductDomain
{
    public class Measurement
    {
        public int Id { get; set; }

        public double Current { get; set; }

        public double Voltage { get; set; }

        public int RunId { get; set; }

        public Run Run { get; set; }
    }
}