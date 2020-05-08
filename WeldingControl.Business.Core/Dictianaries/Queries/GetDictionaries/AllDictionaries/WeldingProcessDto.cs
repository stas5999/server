using System;
using System.Collections.Generic;
using System.Text;

namespace WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries
{
    public class WeldingProcessDto
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }

        public string Abbreviation { get; set; }
    }
}
