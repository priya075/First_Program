using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationDefaultFacility
    {
        public int Deffacid { get; set; }
        public int? CtptId { get; set; }
        public string? AppId { get; set; }
        public string? FacId { get; set; }
        public int? Factypid { get; set; }
        public int? FactypT24pid { get; set; }
        public string? Factypdesc { get; set; }
        public int? FacilityLevel { get; set; }
        public decimal? ApprovedLimit { get; set; }
        public string? ApprovedLimitCcy { get; set; }
        public decimal? ProposedLimit { get; set; }
        public string? ProposedLimitCcy { get; set; }
        public decimal? ExistingLimit { get; set; }
        public string? ExistingLimitCcy { get; set; }
        public decimal? UtilizationLimit { get; set; }
        public string? UtilizationLimitCcy { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? LimitRefCode { get; set; }
    }
}
