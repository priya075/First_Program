using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblXmltablesFieldsMap
    {
        public int Xmid { get; set; }
        public int? Xid { get; set; }
        public bool? IsXmlfield { get; set; }
        public string? FieldName { get; set; }
        public string? FieldDescription { get; set; }
        public string? FieldLength { get; set; }
        public int? SortOrder { get; set; }
    }
}
