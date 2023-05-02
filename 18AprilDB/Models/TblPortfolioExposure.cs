using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolioExposure
    {
        public int Id { get; set; }
        public int? PPtypid { get; set; }
        public string? PName { get; set; }
        public string? Ccy { get; set; }
        public decimal? ContractedExposure { get; set; }
        public decimal? Outstanding { get; set; }
        public string? CustomerType { get; set; }
    }
}
