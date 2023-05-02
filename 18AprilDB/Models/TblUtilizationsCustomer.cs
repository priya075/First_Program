using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUtilizationsCustomer
    {
        public int Trnid { get; set; }
        public int? CtptId { get; set; }
        public string? CustomerCif { get; set; }
        public string? LimitRefCode { get; set; }
        public string? FacilityId { get; set; }
        public string? TransactionAccountNumber { get; set; }
        public decimal? Mtmamount { get; set; }
        public string? Mtmccy { get; set; }
        public decimal? MtmamountBaseCcy { get; set; }
        public decimal? NotionalAmount { get; set; }
        public string? NotionalCcy { get; set; }
        public decimal? NotionalAmountBaseCcy { get; set; }
        public DateTime? ExposureStartDate { get; set; }
        public DateTime? ExposureEndDate { get; set; }
        public string? ProductType { get; set; }
        public string? AssetType { get; set; }
        public decimal? AddonFactor { get; set; }
        public string? Tenor { get; set; }
        public decimal? AddonValueBaseCcy { get; set; }
        public decimal? ExposureBaseCcy { get; set; }
        public bool? IsRealTime { get; set; }
        public string? BaseCcy { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
