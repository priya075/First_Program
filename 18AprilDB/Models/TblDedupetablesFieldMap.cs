using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDedupetablesFieldMap
    {
        public int Dufmid { get; set; }
        public int? Duid { get; set; }
        public bool? IsXmlfield { get; set; }
        public string? ParameterName { get; set; }
        public string? Xpath { get; set; }
        public string? SourceTableFieldName { get; set; }
        public string? FieldDataType { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
    }
}
