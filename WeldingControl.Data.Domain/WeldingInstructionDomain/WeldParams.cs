using System;
using WeldingControl.Data.Domain.Utility;

namespace WeldingControl.Data.Domain.WeldingInstructionDomain
{
    public class WeldParams
    {
        public int Id { get; set; }

        public Param Current { get; set; }

        public Param Thickness { get; set; }

        public Param PipeOuterDiameter { get; set; }

        public int? WeldingProcessId { get; set; }

        public int? ConnectionFormId { get; set; }

        public int? WeldTypeId { get; set; }

        public int? MainMaterialId { get; set; }

        public int? FillerMaterialId { get; set; }

        public int? ShieldingGasId { get; set; }

        public int? WeldingMaterialId { get; set; }

        public int? AdditionalMaterialId { get; set; }

        public int? WeldingPositionId { get; set; }

        public int WeldingInstructionId { get; set; }

        public WeldingProcess WeldingProcess { get; set; }

        public ConnectionForm ConnectionForm { get; set; }

        public WeldType WeldType { get; set; }

        public MainMaterial MainMaterial { get; set; }

        public FillerMaterial FillerMaterial { get; set; }

        public ShieldingGas ShieldingGas { get; set; }

        public WeldingMaterial WeldingMaterial { get; set; }

        public AdditionalMaterial AdditionalMaterial { get; set; }

        public WeldingPosition WeldingPosition { get; set; }

        public WeldingInstruction WeldingInstruction { get; set; }
    }
}