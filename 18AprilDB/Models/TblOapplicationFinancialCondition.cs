using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationFinancialCondition
    {
        public int Fincndid { get; set; }
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string? FinancialConditionId { get; set; }
        public string? ConditionType { get; set; }
        public string? XmlDetails { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
