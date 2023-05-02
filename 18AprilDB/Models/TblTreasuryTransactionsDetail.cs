using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTreasuryTransactionsDetail
    {
        public int TrId { get; set; }
        public int? CtptId { get; set; }
        public string? Customercif { get; set; }
        public string? AccountNo { get; set; }
        public string? ProductFamily { get; set; }
        public string? AssetClass { get; set; }
        public string? PortfolioName { get; set; }
        public string? Product { get; set; }
        public string? BuyCcy { get; set; }
        public string? Buyorsell { get; set; }
        public string? SellCcy { get; set; }
        public string? CurrencyPair { get; set; }
        public string? TreasuryCustid { get; set; }
        public string? ClsParty { get; set; }
        public string? ContractNo { get; set; }
        public string? Currency { get; set; }
        public string? FarLeg { get; set; }
        public string? IfscCode { get; set; }
        public string? IssuerId { get; set; }
        public string? CredproFacilityId { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? MtmAmount { get; set; }
        public string? MtmAmountCcy { get; set; }
        public string? NearLeg { get; set; }
        public decimal? NotionalAmount { get; set; }
        public decimal? AddonFactor { get; set; }
        public decimal? AddonAmount { get; set; }
        public decimal? Pfe { get; set; }
        public string? ReferenceEntity { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string? SettlementMethod { get; set; }
        public DateTime? StartDate { get; set; }
        public string? SwiftId { get; set; }
        public string? Tenor { get; set; }
        public DateTime? TradeDate { get; set; }
        public DateTime? TradeInsertionDate { get; set; }
        public string? TradeNo { get; set; }
        public string? TraderId { get; set; }
        public string? Underlying { get; set; }
        public DateTime? ValueDate { get; set; }
        public string? LegalAgreement { get; set; }
        public string? SecurityName { get; set; }
        public string? SecurityDescription { get; set; }
        public string? ExposureType { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
