using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class LmExpCal
    {
        public string? TrnId { get; set; }
        public int? Facid { get; set; }
        public decimal? ExposureAmount { get; set; }
        public string? ExposureCcy { get; set; }
        public string? Rt { get; set; }
        public string? ResId { get; set; }
        public string? TrnType { get; set; }
    }
}
