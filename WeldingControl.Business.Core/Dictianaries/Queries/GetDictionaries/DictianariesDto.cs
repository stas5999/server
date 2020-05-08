using System;
using System.Collections.Generic;
using System.Text;
using WeldingControl.Shared.Constants.Enums;
using System.Linq;

namespace WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries
{
    public class DictionariesDto
    {
        public IEnumerable<AdditionalMaterialDto> AdditionalMaterials { get; set; }

        public IEnumerable<ConnectionFormDto> ConnectionForms { get; set; }

        public IEnumerable<FillerMaterialDto> FillerMaterials { get; set; }

        public IEnumerable<MainMaterialDto> MainMaterials { get; set; }

        public IEnumerable<OrganizationDto> Organizations { get; set; }

        public IEnumerable<ShieldingGasDto> ShieldingGas { get; set; }

        public IEnumerable<WeldingMaterialDto> WeldingMaterials { get; set; }

        public IEnumerable<WeldingPositionDto> WeldingPositions { get; set; }

        public IEnumerable<WeldingProcessDto> WeldingProcesses { get; set; }

        public IEnumerable<WeldingTechniqueDto> WeldingTechniques { get; set; } 

        public IEnumerable<WeldTypeDto> WeldTypes { get; set; }
    }
}
