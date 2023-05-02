using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Mra2cmsFinancialStmt
    {
        public string? StatementId { get; set; }
        public string? CustomerCif { get; set; }
        public string? CustomerName { get; set; }
        public string? StatementDate { get; set; }
        public string? Period { get; set; }
        public string? StatedmentAuditStatus { get; set; }
        public string? StatementTypeAnnualYtd { get; set; }
        public string? IsQualified { get; set; }
        public string? TurnoverTotalSales { get; set; }
        public string? GrossProfitLoss { get; set; }
        public string? GrossProfitMargin { get; set; }
        public string? NetProfitLoss { get; set; }
        public string? NetProfitMargin { get; set; }
        public string? OtherIncome { get; set; }
        public string? TradeDebtorDays { get; set; }
        public string? StockDaysDays { get; set; }
        public string? TradeCreditorDays { get; set; }
        public string? ConversionCycleDays { get; set; }
        public string? TotalAssets { get; set; }
        public string? OfWhichRelatedPartiesDuesDrp { get; set; }
        public string? TotalLiabilities { get; set; }
        public string? OfWhichDebt { get; set; }
        public string? Contingencies { get; set; }
        public string? CapitalCommitments { get; set; }
        public string? WorkingCapital { get; set; }
        public string? CurrentRatio { get; set; }
        public string? PaidUpCapital { get; set; }
        public string? TangibleNetWorth { get; set; }
        public string? WithdrawnProfits { get; set; }
        public string? IntroductionOfFunds { get; set; }
        public string? Leverage { get; set; }
        public string? AdjustedLeverage { get; set; }
        public string? NetDebtInclContingenciesToEquity { get; set; }
    }
}
