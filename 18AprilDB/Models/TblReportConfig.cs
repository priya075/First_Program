using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReportConfig
    {
        public int Id { get; set; }
        public string? RptName { get; set; }
        public string? ValueType { get; set; }
        public string? Value { get; set; }
        public int? SortOrder { get; set; }
    }
}
