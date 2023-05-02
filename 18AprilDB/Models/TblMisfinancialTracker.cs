using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisfinancialTracker
    {
        public int? WfstappId { get; set; }
        public string? FinId { get; set; }
        public string? AppId { get; set; }
        public int? CtptId { get; set; }
        public string? FinancialType { get; set; }
        public int? FinancialTypeId { get; set; }
        public string? XmlFinancial { get; set; }
        public int? LastAudFinYear { get; set; }
        public string? LastAuditedAmount { get; set; }
    }
}
