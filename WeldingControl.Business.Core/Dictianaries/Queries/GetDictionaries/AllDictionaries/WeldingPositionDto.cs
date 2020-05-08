using System;
using System.Collections.Generic;
using System.Text;

namespace WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries
{
    public class WeldingPositionDto
    {
        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
