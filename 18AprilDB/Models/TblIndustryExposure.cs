using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblIndustryExposure
    {
        public string? IndustryCode { get; set; }
        public string? IndustryName { get; set; }
        public string? Fbadvances { get; set; }
        public string? Nfbadvances { get; set; }
        public string? DerivativeMtm { get; set; }
        public string? Investments { get; set; }
        public string? Total { get; set; }
        public string? PercentageTotalInGrossGl { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
