using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutProposalFacility
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? FacilityDesc { get; set; }
        public string? FacSrNo { get; set; }
        public string? ClaimType { get; set; }
        public string? FacParentSrNo { get; set; }
        public DateTime? FacStartDate { get; set; }
        public DateTime? FacEndDate { get; set; }
        public string? FacGrpName { get; set; }
        public string? UcfFlag { get; set; }
        public decimal? ExistingLimit { get; set; }
        public decimal? OutstandingAmt { get; set; }
        public decimal? ProposedLimit { get; set; }
        public string? Currency { get; set; }
        public decimal? ExpectedDdCcf1 { get; set; }
        public decimal? ActualExpectedDdCcf1 { get; set; }
        public decimal? ExpectedDevCcf2 { get; set; }
        public decimal? OverallCap { get; set; }
        public decimal? Lgd { get; set; }
        public string? ObligorRating { get; set; }
        public string? FacRating { get; set; }
        public string? ElRating { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IsProposalDeleted { get; set; }
    }
}
