using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinancialsAdjSen
    {
        public int CtptId { get; set; }
        public int FinYear { get; set; }
        public int FinMonth { get; set; }
        public int FinCompId { get; set; }
        public decimal? Amount { get; set; }
        public string? Remarks { get; set; }
        public int TmpId { get; set; }
        public int StmtId { get; set; }
    }
}
