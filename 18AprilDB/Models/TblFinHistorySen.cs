using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinHistorySen
    {
        public decimal? AdId { get; set; }
        public decimal FinCompId { get; set; }
        public decimal? Amount { get; set; }
        public int FinYear { get; set; }
        public DateTime? FinDate { get; set; }
        public int CtptId { get; set; }
        public int FinMonth { get; set; }
        public int StmtId { get; set; }
        public int TmpId { get; set; }
    }
}
