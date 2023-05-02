using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutDetailRiskRpt
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? ScoringDtlsDesc { get; set; }
        public string? ScoreValue { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IsProposalDeleted { get; set; }
        public string? SectionId { get; set; }
        public string? SrNo { get; set; }
    }
}
