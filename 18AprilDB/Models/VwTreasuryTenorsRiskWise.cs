using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwTreasuryTenorsRiskWise
    {
        public int Bid { get; set; }
        public string? BucketName { get; set; }
        public int Tid { get; set; }
        public string? TenorDesc { get; set; }
        public int? Tenor { get; set; }
        public string? TenorUnit { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public int Bpmid { get; set; }
        public string? RiskType { get; set; }
        public string? ProductType { get; set; }
        public string? FacilityType { get; set; }
        public int? LmDisplayOrder { get; set; }
    }
}
