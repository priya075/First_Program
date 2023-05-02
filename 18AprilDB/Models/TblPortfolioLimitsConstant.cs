using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioLimitsConstant
    {
        public int ConstantId { get; set; }
        public string? Name { get; set; }
        public decimal? Amount { get; set; }
        public string? Ccy { get; set; }
    }
}
