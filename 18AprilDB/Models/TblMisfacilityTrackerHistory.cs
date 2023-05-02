using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisfacilityTrackerHistory
    {
        public int WfstappId { get; set; }
        public int CtptId { get; set; }
        public string AppId { get; set; } = null!;
        public string FacId { get; set; } = null!;
        public string? ParentFacId { get; set; }
        public int? Subtype { get; set; }
        public int? FacilityLevel { get; set; }
        public decimal? ProposedLimitAmount { get; set; }
        public string? ProposedLimitCurrencyDesc { get; set; }
        public decimal? ApprovedLimitAmount { get; set; }
        public string? ApprovedLimitCurrencyDesc { get; set; }
        public decimal? NotionalLimit { get; set; }
        public int? BalanceTransfer { get; set; }
        public int BtbankId { get; set; }
        public decimal? ProposedLimitAmountInr { get; set; }
        public decimal? ApprovedLimitAmountInr { get; set; }
        public string? BtFlag { get; set; }
        public string? BtBankName { get; set; }
        public int? IsMigratedLimit { get; set; }
    }
}
