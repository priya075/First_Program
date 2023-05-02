using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MraFinancialDataNewformat1
    {
        public decimal StatementId { get; set; }
        public string? CustomerCif { get; set; }
        public string? CustomerName { get; set; }
        public string? StatementDate { get; set; }
        public string? Period { get; set; }
        public string? Audited { get; set; }
        public string? PastOrProjection { get; set; }
        public string? AnnualYtd { get; set; }
        public string? IsQualified { get; set; }
        public string? TurnoverTotalSales { get; set; }
        public string? GrossProfitLoss { get; set; }
        public string? GrossProfitMarginPercent { get; set; }
        public string? NetProfitLoss { get; set; }
        public string? NetProfitMarginPercent { get; set; }
        public string? Otherincome { get; set; }
        public string? TradeDebtorDays { get; set; }
        public string? StockDaysDays { get; set; }
        public string? TradeCreditorDays { get; set; }
        public string? ConversionCycleDays { get; set; }
        public string? TotalAssets { get; set; }
        public string? OfwhichRelatedpartiesduesDrp { get; set; }
        public string? TotalLiabilities { get; set; }
        public string? OfwhichDebt { get; set; }
        public string? Contingencies { get; set; }
        public string? CapitalCommitments { get; set; }
        public string? WorkingCapital { get; set; }
        public string? CurrentRatio { get; set; }
        public string? PaidupCapital { get; set; }
        public string? TangibleNetWorth { get; set; }
        public string? WithdrawnProfits { get; set; }
        public string? Introductionoffunds { get; set; }
        public string? Leverage { get; set; }
        public string? AdjustedLeverage { get; set; }
        public string? NetDebtinclcontingenciestoEquity { get; set; }
        public string? FinancialCurrency { get; set; }
        public string? DisplayUnit { get; set; }
    }
}
