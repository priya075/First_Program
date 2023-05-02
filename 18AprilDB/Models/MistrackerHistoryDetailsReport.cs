using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MistrackerHistoryDetailsReport
    {
        public string? AppId { get; set; }
        public string? UniqueId { get; set; }
        public string? RegionName { get; set; }
        public int? LeadRmId { get; set; }
        public string? LeadRm { get; set; }
        public string? CounterPartyName { get; set; }
        public string? DepartmentName { get; set; }
        public decimal? Exposure { get; set; }
        public DateTime? LoginAcceptedDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? LoginSanctionDateDiff { get; set; }
        public decimal? LoginacceptanceBusinesstray { get; set; }
        public decimal? LoginacceptanceCredittray { get; set; }
        public decimal? BusinessTray { get; set; }
        public decimal? UnderwritingTray { get; set; }
        public decimal? RecommendorTray { get; set; }
        public decimal? ApproverTray { get; set; }
        public decimal? TotalTat { get; set; }
    }
}
