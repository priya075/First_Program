using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TempStdatum
    {
        public int StmtId { get; set; }
        public int? ClientStmtId { get; set; }
        public int? CtptId { get; set; }
        public int? TmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Period { get; set; }
        public string? PastOrProjection { get; set; }
        public string? Audited { get; set; }
        public string? AnnualYtd { get; set; }
        public string? IsQualified { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? FinancialCurrency { get; set; }
        public string? DisplayUnit { get; set; }
        public bool? IsApproved { get; set; }
    }
}
