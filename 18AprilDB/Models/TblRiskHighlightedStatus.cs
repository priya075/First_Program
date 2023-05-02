using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRiskHighlightedStatus
    {
        public string? SNo { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? AccountNo { get; set; }
        public string? BusinessProfile { get; set; }
        public string? MonthOfClassification { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Facility { get; set; }
        public string? TypeOfFacility { get; set; }
        public string? LoanAmtInRsCr { get; set; }
        public string? OsucInCr { get; set; }
        public string? PosCr { get; set; }
        public string? BgDetails { get; set; }
        public string? TlRepaymentsAsOn30420 { get; set; }
        public string? DpdAsOnDate { get; set; }
        public string? SecurityValueCr { get; set; }
        public string? SecurityDetails { get; set; }
        public string? RiskClassification { get; set; }
        public string? RootCause { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ChurningRemarks { get; set; }
        public string? StatusOfChequeReturns { get; set; }
        public string? OverdueTrend { get; set; }
        public string? CurrentOverdueStatus { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
