using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioLimit
    {
        public int PPl { get; set; }
        public int? PPid { get; set; }
        public string? PParameter { get; set; }
        public decimal? LimitValue { get; set; }
        public string? LimitCcy { get; set; }
        public decimal? PercentageValue { get; set; }
    }
}
