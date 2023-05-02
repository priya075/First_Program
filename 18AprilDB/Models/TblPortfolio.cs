using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblPortfolio
    {
        public int PrctId { get; set; }
        public int PrtId { get; set; }
        public string PortfolioName { get; set; } = null!;
        public string? PortfolioDescription { get; set; }
        public int CtptId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
