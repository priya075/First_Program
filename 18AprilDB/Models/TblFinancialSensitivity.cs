using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinancialSensitivity
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public int? TmpId { get; set; }
        public int? PrmId { get; set; }
        public decimal? PercentChange { get; set; }
    }
}
