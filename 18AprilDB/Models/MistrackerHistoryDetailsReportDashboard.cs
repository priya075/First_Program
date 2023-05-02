using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MistrackerHistoryDetailsReportDashboard
    {
        public string? AppId { get; set; }
        public string? UniqueId { get; set; }
        public string? RegionName { get; set; }
        public string? LeadRmEmployeeId { get; set; }
        public string? LeadRm { get; set; }
        public string? CounterPartyName { get; set; }
        public string? DepartmentName { get; set; }
        public string? PurposeofCa { get; set; }
        public string? Wfname { get; set; }
        public string IsLoginAccepted { get; set; } = null!;
        public DateTime? LoginAcceptedDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? SanctionDate { get; set; }
        public int? SanctionCount { get; set; }
        public DateTime? FirstSanctionDate { get; set; }
        public DateTime? AppStartDate { get; set; }
        public int? AppStartMonth { get; set; }
        public int? AppStartYear { get; set; }
        public string IsAbort { get; set; } = null!;
        public string IsDecline { get; set; } = null!;
        public decimal? FundedApprovedLimitInr { get; set; }
        public decimal? NonFundedApprovedLimitInr { get; set; }
        public decimal? TotalApprovedLimitInr { get; set; }
    }
}
