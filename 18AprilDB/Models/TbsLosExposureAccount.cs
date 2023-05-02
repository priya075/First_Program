using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TbsLosExposureAccount
    {
        public string? CustomerId { get; set; }
        public string? AccountNumber { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? SchemeCode { get; set; }
        public string? SchemeType { get; set; }
        public string? AccountStatus { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? DrawingPower { get; set; }
        public decimal? SanctionLimit { get; set; }
        public int? Dpd { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
