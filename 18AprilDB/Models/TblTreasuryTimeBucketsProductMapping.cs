using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTreasuryTimeBucketsProductMapping
    {
        public int Bpmid { get; set; }
        public int? Bid { get; set; }
        public string? RiskType { get; set; }
        public string? ProductType { get; set; }
        public string? FacilityType { get; set; }
        public int? LmDisplayOrder { get; set; }
        public int? ParentAssetId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
