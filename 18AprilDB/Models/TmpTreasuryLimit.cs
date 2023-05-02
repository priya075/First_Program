using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TmpTreasuryLimit
    {
        public int? CtptId { get; set; }
        public int Amid { get; set; }
        public string? Facid { get; set; }
        public string? ParentFacilityId { get; set; }
        public int? Type { get; set; }
        public string? TypeDesc { get; set; }
        public int? Subtype { get; set; }
        public string? SubtypeDesc { get; set; }
        public decimal? ApprovedLimit { get; set; }
        public int? ApprovedLimitCcy { get; set; }
        public string? TreasuryTenor { get; set; }
        public string? RiskType { get; set; }
        public string? ProductType { get; set; }
        public string? TenorDesc { get; set; }
        public int? TenorOrder { get; set; }
        public int? ProductOrder { get; set; }
        public int BucketId { get; set; }
        public int TenorId { get; set; }
    }
}
