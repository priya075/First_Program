using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationFinancialCovenant
    {
        public int Fincovid { get; set; }
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string? FinancialCovenantId { get; set; }
        public string? XmlDetails { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
