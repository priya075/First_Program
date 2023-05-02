using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationFinancial
    {
        public int Fnid { get; set; }
        public int Amid { get; set; }
        public int CtptId { get; set; }
        public string PeriodEnded { get; set; } = null!;
        public int PeriodInMonths { get; set; }
        public decimal? NetSales { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? Pbildt { get; set; }
        public decimal? Interest { get; set; }
        public string? Depreciation { get; set; }
        public decimal? OperatingProfit { get; set; }
        public decimal? Pat { get; set; }
        public decimal? FinancialPositionNetFixedAssets { get; set; }
        public decimal? FinancialPositionCurrentAssets { get; set; }
        public decimal? FinancialPositionCurrentLiabilities { get; set; }
        public decimal? FinancialPositionNetWorkingCapital { get; set; }
        public decimal? FinancialPositionEquityShareCapital { get; set; }
        public decimal? FinancialPositionNetworth { get; set; }
        public decimal? FinancialPositionTotalCapitalEmployed { get; set; }
        public decimal? Growth { get; set; }
        public int? GrowthInPbildt { get; set; }
        public decimal? Profitability { get; set; }
        public int? ProfitabilityOperatingProfitPerTotalIncome { get; set; }
        public int? ProfitabilityRoceTotal { get; set; }
        public int? ProfitabilityRonw { get; set; }
        public decimal? Solvency { get; set; }
        public int? SolvencyLongTermDebtEquityRatio { get; set; }
        public int? SolvencyInterestCoverage { get; set; }
        public int? SolvencyTotalDebtPerNetCashAccruals { get; set; }
        public int? Liquidity { get; set; }
        public int? LiquidityCurrentRatio { get; set; }
        public int? LiquidityQuickRatio { get; set; }
        public int? Turnover { get; set; }
        public int? TurnoverWorkingCapitalTurnoverRatio { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
