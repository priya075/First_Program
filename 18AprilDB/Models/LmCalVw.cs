using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class LmCalVw
    {
        public string? Facid { get; set; }
        public string? RootFacid { get; set; }
        public string? Ccy { get; set; }
        public decimal? Exposure { get; set; }
        public decimal? Reservation { get; set; }
        public decimal? RealExposure { get; set; }
        public decimal? Sod { get; set; }
        public decimal? RealAvailable { get; set; }
    }
}
