using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisapplicationSummaryTrackerHistory
    {
        public string AppId { get; set; } = null!;
        public decimal? FundedProposedLimitInr { get; set; }
        public decimal? NonFundedProposedLimitInr { get; set; }
        public decimal? LoanProposedLimitInr { get; set; }
        public decimal? LerProposedLimitInr { get; set; }
        public decimal? TotalProposedLimitInr { get; set; }
        public decimal? FundedApprovedLimitInr { get; set; }
        public decimal? NonFundedApprovedLimitInr { get; set; }
        public decimal? LoanApprovedLimitInr { get; set; }
        public decimal? LerApprovedLimitInr { get; set; }
        public decimal? TotalApprovedLimitInr { get; set; }
        public decimal? NotionalLimit { get; set; }
    }
}
