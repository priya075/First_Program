using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioDefinition
    {
        public int PPid { get; set; }
        public string? PType { get; set; }
        public string? PParameter { get; set; }
        public string? StaticTable { get; set; }
        public string? StaticTableColumnId { get; set; }
        public string? StaticTableColumnName { get; set; }
        public string? HierarchyFlag { get; set; }
        public string? HierarchyTable { get; set; }
        public bool? IsActive { get; set; }
        public string? HierarchyKeyColumn { get; set; }
        public bool? IsPercentageValue { get; set; }
        public int? ConstantId { get; set; }
    }
}
