using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTreasuryLimitsCtpt
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public int? Amid { get; set; }
        public string? Facid { get; set; }
        public string? ParentFacilityId { get; set; }
        public string? Type { get; set; }
        public string? TypeDesc { get; set; }
        public int? Subtype { get; set; }
        public string? SubtypeDesc { get; set; }
        public string? RiskType { get; set; }
        public string? ProductType { get; set; }
        public decimal? ApprovedLimit { get; set; }
        public int? ApprovedLimitCcy { get; set; }
        public string? TreasuryTenor { get; set; }
        public int? Tid { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
