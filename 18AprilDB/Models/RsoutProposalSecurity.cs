using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutProposalSecurity
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? SecurityDesc { get; set; }
        public string? SecSrNo { get; set; }
        public DateTime? ProposedStartDate { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public DateTime? ValidDate { get; set; }
        public string? ValidSource { get; set; }
        public decimal? ValuedAtAmt { get; set; }
        public string? Currency { get; set; }
        public string? Rating { get; set; }
        public string? SecurityCreated { get; set; }
        public string? SecurityAddrDet { get; set; }
        public string? SecurityStateId { get; set; }
        public string? SecurityCityId { get; set; }
        public string? SecurityPinCode { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IsProposalDeleted { get; set; }
    }
}
