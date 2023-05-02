using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExposuresuploadSourceSystemCfd
    {
        public string? CifId { get; set; }
        public string? Foracid { get; set; }
        public string? AcctName { get; set; }
        public string? SchmType { get; set; }
        public string? SchmCode { get; set; }
        public string? OutstandingAcctCcy { get; set; }
        public string? OutstandingHomeCcy { get; set; }
        public string? AcctCcy { get; set; }
        public string? HomeCcy { get; set; }
        public string? ConvRate { get; set; }
        public string? ExpoStartDate { get; set; }
        public string? ExpoEndDate { get; set; }
        public string? ExpoEffectiveDate { get; set; }
        public string? CredproFacilityId { get; set; }
        public string? MarginAmt { get; set; }
        public string? MarginCcy { get; set; }
        public string? LimitPrefix { get; set; }
        public string? LimitSuffix { get; set; }
        public string? SanctLim { get; set; }
        public string? DrwngPower { get; set; }
        public string? PricingRefRate { get; set; }
        public string? FixedIntRate { get; set; }
        public string? Spread { get; set; }
        public string? WholesaleFlg { get; set; }
        public string? NpaStatus { get; set; }
        public string? SmaStat { get; set; }
        public string? UnutilAmt { get; set; }
        public string? AvgUtil { get; set; }
        public string? FutureInt { get; set; }
        public string? LienAmt { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
