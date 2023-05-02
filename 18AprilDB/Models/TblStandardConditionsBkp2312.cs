using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblStandardConditionsBkp2312
    {
        public int ConditionId { get; set; }
        public string? ConditionText { get; set; }
        public int? ApplicationType { get; set; }
        public int? ConditionType { get; set; }
        public string? SectionName { get; set; }
        public int? SortOrder { get; set; }
        public string? Header { get; set; }
        public bool? IsCommunicated { get; set; }
        public int? PrePost { get; set; }
        public int? DefaultMonFreq { get; set; }
    }
}
