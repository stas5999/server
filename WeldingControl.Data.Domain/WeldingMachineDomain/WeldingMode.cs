using WeldingControl.Data.Domain.Utility;

namespace WeldingControl.Data.Domain.WeldingMachineDomain
{
    public class WeldingMode
    {
        public int Id { get; set; }

        public Param Current { get; set; }

        public int EquipmentId { get; set; }

        public int WeldingProcessId { get; set; }

        public WeldingMachine WeldingMachine { get; set; }

        public WeldingProcess WeldingProcess { get; set; }
    }
}