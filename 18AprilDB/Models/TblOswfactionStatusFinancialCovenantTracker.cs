using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusFinancialCovenantTracker
    {
        public int WfstfincovId { get; set; }
        public int? WfstappId { get; set; }
        public int? WfaId { get; set; }
        public string? FinancialCovenantId { get; set; }
        public int? RId { get; set; }
        public string? MId { get; set; }
        public int? ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? XmlFinancialCovenant { get; set; }
    }
}
