using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwReportCollateral
    {
        public int AcId { get; set; }
        public string? Colid { get; set; }
        public int Amid { get; set; }
        public string? SanctionId { get; set; }
        public int CtptId { get; set; }
        public string? Counterparty { get; set; }
        public bool? IsSpecificFlag { get; set; }
        public string? Facid { get; set; }
        public string? InitialSnid { get; set; }
        public string? CurrentSnid { get; set; }
        public string? InApplicationCollateralStatus { get; set; }
        public int Colmapid { get; set; }
        public string? CollateralType { get; set; }
        public string? CollateralSubType { get; set; }
        public decimal? CollateralValue { get; set; }
        public int CollateralValueCurrencyId { get; set; }
        public string? CollateralValueCurrency { get; set; }
        public DateTime? CollateralValuationDate { get; set; }
        public string? CollateralValuer { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SecurityType { get; set; }
        public string? Guarantor { get; set; }
        public string? GuarantorType { get; set; }
        public decimal? GuaranteeAmount { get; set; }
        public int? GuaranteeCurrency { get; set; }
        public bool? IsLimitedFlag { get; set; }
        public bool? IsRevocableFlag { get; set; }
        public DateTime? GuaranteeValidityDate { get; set; }
        public string? GuarantorCounterpartyRelationship { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountWithBank { get; set; }
        public string? AssetDescription { get; set; }
        public string? AssetLocation { get; set; }
        public bool? BorrowerIsOwnerOfAsset { get; set; }
        public int? ChargeLevel { get; set; }
    }
}
