using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMisdeviationTracker
    {
        public int WfstappId { get; set; }
        public string AppId { get; set; } = null!;
        public string Exposure { get; set; } = null!;
        public string BorrowerProfile { get; set; } = null!;
        public string FinancialParameters { get; set; } = null!;
        public string BankingHistory { get; set; } = null!;
        public string DefaultHistory { get; set; } = null!;
        public string OwnerMargin { get; set; } = null!;
        public string RiskParameterScore { get; set; } = null!;
        public string PromoterAndGuarantorAge { get; set; } = null!;
        public string Assessment { get; set; } = null!;
        public string Collateral { get; set; } = null!;
        public string PersonalGuarantee { get; set; } = null!;
        public string Tenor { get; set; } = null!;
        public string Other { get; set; } = null!;
    }
}
