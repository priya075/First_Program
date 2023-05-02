using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationPricingAndProfitability
    {
        public int Priprfid { get; set; }
        public int? Amid { get; set; }
        public int? CtptId { get; set; }
        public string? ExistingArrangementFee { get; set; }
        public string? CustomerLevelCharges { get; set; }
        public string? Type { get; set; }
        public string? Code { get; set; }
        public string? Existing { get; set; }
        public string? ProposedOrApproved { get; set; }
        public bool? IsCommunicated { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
