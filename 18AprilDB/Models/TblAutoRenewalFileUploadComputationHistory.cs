using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAutoRenewalFileUploadComputationHistory
    {
        public int Hid { get; set; }
        public int Id { get; set; }
        public int? FuId { get; set; }
        public string CustId { get; set; } = null!;
        public int WfstarId { get; set; }
        public string Program { get; set; } = null!;
        public decimal? CpApprovedLimit { get; set; }
        public decimal? CpChurningTurnOver { get; set; }
        public decimal? CpCollateralTotalValue { get; set; }
        public string? SAverageLimitUtilizationLevel { get; set; }
        public string? SAverageInterestServicing { get; set; }
        public string? SInwardChequeReturns { get; set; }
        public string? SChurningAtCustomerLevel { get; set; }
        public string? SOverallScore { get; set; }
        public string? EPostDisbVintage { get; set; }
        public string? ECollateralCoverage { get; set; }
        public string? EBorrowerTotalExposure { get; set; }
        public string? EGroupTotalExposure { get; set; }
        public string? EChurning { get; set; }
        public string? EAverageInterestServicing { get; set; }
        public string? EMaxInterestServicing { get; set; }
        public string? ELimitUtilization { get; set; }
        public string? EInwardReturn { get; set; }
        public string? EAverageEmiservicingofTl { get; set; }
        public string? EMaxEmiservicingofTl { get; set; }
        public string? EOverdrawnDays { get; set; }
        public string? ENoDevolvementInvocation { get; set; }
        public string? ENoIrregularTodAdhoc { get; set; }
        public string? EAccountsRenewed { get; set; }
        public string? EBankingScore { get; set; }
        public string? EOverallEligibility { get; set; }
        public string? EManualEligibility { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string? Justification { get; set; }
    }
}
