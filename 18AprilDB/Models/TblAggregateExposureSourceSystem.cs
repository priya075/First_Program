using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAggregateExposureSourceSystem
    {
        public int? CtptId { get; set; }
        public string? CifId { get; set; }
        public decimal? TotalFb { get; set; }
        public decimal? Nfb { get; set; }
        public decimal? TotalOsInCrores { get; set; }
        public decimal? GrossFbExposure { get; set; }
        public decimal? GrossNfbExposure { get; set; }
        public decimal? GrossTotalExposure { get; set; }
        public decimal? NetFbExposure { get; set; }
        public decimal? NetNfbExposure { get; set; }
        public decimal? NetTotalExposure { get; set; }
        public decimal? ExposureFbOs { get; set; }
        public decimal? ExposureNfbOs { get; set; }
        public string? FbNodeDpdBucket { get; set; }
        public DateTime? ReportDate { get; set; }
    }
}
