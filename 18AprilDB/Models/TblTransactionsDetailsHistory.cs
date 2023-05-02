using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTransactionsDetailsHistory
    {
        public int? CtptId { get; set; }
        public string? CustomerCif { get; set; }
        public string? LimitRefCode { get; set; }
        public string? FacilityId { get; set; }
        public string? TransactionAccountNumber { get; set; }
        public decimal? Mtmamount { get; set; }
        public string? Mtmccy { get; set; }
        public decimal? NotionalAmount { get; set; }
        public string? NotionalCcy { get; set; }
        public DateTime? ExposureStartDate { get; set; }
        public DateTime? ExposureEndDate { get; set; }
        public string? ProductType { get; set; }
        public string? AssetType { get; set; }
        public DateTime? LoadDate { get; set; }
        public decimal? MtmamountHomeCcy { get; set; }
        public decimal? NotionalAmountHomeCcy { get; set; }
        public string? MtmhomeCcy { get; set; }
        public string? NotionalHomeCcy { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? DepositAmountHomeCcy { get; set; }
    }
}
