using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExposuresuploadSourceSystemFxd
    {
        public int Id { get; set; }
        public string? AssetClass { get; set; }
        public string? BuyCcy { get; set; }
        public string? BuyOrSell { get; set; }
        public string? TreasuryCustomerId { get; set; }
        public string? Clsparty { get; set; }
        public string? TradeCurency { get; set; }
        public string? FarLeg { get; set; }
        public string? CoreCusId { get; set; }
        public string? MaturityDate { get; set; }
        public decimal? Mtmamount { get; set; }
        public string? Mtmcurrency { get; set; }
        public string? NearLeg { get; set; }
        public decimal? NotionalAmount { get; set; }
        public string? PortfolioName { get; set; }
        public string? Product { get; set; }
        public string? ReferenceEntity { get; set; }
        public string? SellCcy { get; set; }
        public string? SettlementDate { get; set; }
        public string? SettlementMethod { get; set; }
        public string? StartDate { get; set; }
        public string? SwiftId { get; set; }
        public string? TradeDate { get; set; }
        public string? TradeNo { get; set; }
        public string? TraderId { get; set; }
        public string? Underlying { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
