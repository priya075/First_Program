using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisapplicationTrackerHistory
    {
        public int? CtptId { get; set; }
        public string? AppId { get; set; }
        public decimal? LoginacceptanceBusinesstray { get; set; }
        public decimal? LoginacceptanceCredittray { get; set; }
        public decimal? BusinessTray { get; set; }
        public decimal? UnderwritingTray { get; set; }
        public decimal? RecommendorTray { get; set; }
        public decimal? ApproverTray { get; set; }
        public decimal? TotalTat { get; set; }
        public DateTime? LoginAcceptedDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? AppRegion { get; set; }
        public int? MWfId { get; set; }
        public int? CustTrackIdout { get; set; }
        public int? LoginAcceptedToApprovalDate { get; set; }
        public string? PurposeofCa { get; set; }
        public DateTime? AppStartDate { get; set; }
        public DateTime? SanctionDate { get; set; }
        public int? SanctionCount { get; set; }
        public DateTime? FirstSanctionDate { get; set; }
        public string? ActionType { get; set; }
    }
}
