using System;
using System.Collections.Generic;
using System.Text;

namespace WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries
{
    public class MainMaterialDto
    {
        public int Id { get; set; }

        public int Group { get; set; }

        public int SubGroup { get; set; }

        public string Description { get; set; }
    }
}
