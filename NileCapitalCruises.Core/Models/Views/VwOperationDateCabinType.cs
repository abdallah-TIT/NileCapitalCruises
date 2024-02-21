using System;
using System.Collections.Generic;

namespace NileCapitalCruises.Core.Models.Views
{
    public class VwOperationDateCabinType
    {
        public int CabinTypeCruiseId { get; set; }
        public int? Allotment { get; set; }
        public string CabinTypeNameSys { get; set; }
        public string CabinTypeName { get; set; }
        public string LanguageAbbreviation { get; set; }
        public string LanguageName { get; set; }
        public string LanguageFlag { get; set; }
        public int OperationDateId { get; set; }
    }
}
