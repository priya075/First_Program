using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioLimitsConsumed
    {
        public int? PPtypid { get; set; }
        public string? PName { get; set; }
        public decimal? LimitAmount { get; set; }
        public string? Ccy { get; set; }
        public decimal? Approved { get; set; }
        public decimal? Proposed { get; set; }
        public decimal? Ipa { get; set; }
    }
}
