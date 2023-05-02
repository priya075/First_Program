using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusConditionTracker
    {
        public int WfstcndId { get; set; }
        public int? WfstappId { get; set; }
        public int? WfaId { get; set; }
        public string? FinancialConditionId { get; set; }
        public string? ConditionType { get; set; }
        public int? RId { get; set; }
        public int? MId { get; set; }
        public int? ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? XmlCondition { get; set; }
    }
}
