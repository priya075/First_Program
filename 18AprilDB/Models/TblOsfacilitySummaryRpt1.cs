using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsfacilitySummaryRpt1
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? AppId { get; set; }
        public decimal? ExistingTotalCreditLimit { get; set; }
        public decimal? ProposedTotalCreditLimit { get; set; }
        public decimal? ExistingGroupTotalLimits { get; set; }
        public decimal? ProposedGroupTotalLimits { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? Type { get; set; }
    }
}
