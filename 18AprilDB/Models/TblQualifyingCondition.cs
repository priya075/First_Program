using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblQualifyingCondition
    {
        public int QcndId { get; set; }
        public string QcndSysName { get; set; } = null!;
        public string QcndDisplayName { get; set; } = null!;
        public string? QcndOperator { get; set; }
        public string? QcndBaseValue { get; set; }
        public string? QcndBaseUnit { get; set; }
        public bool? QcndIsBaseValueNumeric { get; set; }
        public bool IsActive { get; set; }
        public int? SortOrder { get; set; }
        public string? SourceTable { get; set; }
        public string? SourceTableColumn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
