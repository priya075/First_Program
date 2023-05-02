using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptscoring
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? ScoringDesc { get; set; }
        public string? Weightages { get; set; }
        public string? IndustryBenchmark { get; set; }
        public string? BorrowerRating { get; set; }
        public string? Score { get; set; }
        public string? WeightedScore { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? CompType { get; set; }
        public string? SectionId { get; set; }
        public string? SrNo { get; set; }
    }
}
