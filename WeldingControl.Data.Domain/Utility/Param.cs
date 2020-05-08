namespace WeldingControl.Data.Domain.Utility
{
    public class Param
    {
        public Param(double min, double? max = null)
        {
            Min = min;
            Max = max;
        }

        public double Min { get; set; }

        public double? Max { get; set; }
    }
}