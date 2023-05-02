using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisapplicationTracker
    {
        public int CtptId { get; set; }
        public string AppId { get; set; } = null!;
        public decimal? LoginAcceptanceBusinessTray { get; set; }
        public decimal? LoginAcceptanceCreditTray { get; set; }
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
        public string? PurposeofCa { get; set; }
        public DateTime? AppStartDate { get; set; }
        public string? ActionType { get; set; }
        public DateTime? SanctionDate { get; set; }
        public int? SanctionCount { get; set; }
        public int? LastApprovedWfstappId { get; set; }
        public string? Tray { get; set; }
        public DateTime? FirstSanctionDate { get; set; }
        public int? LoginAcceptedToApprovalDate { get; set; }
    }
}
