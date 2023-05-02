using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutProposalBorrRaroc
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? BorrRating { get; set; }
        public decimal? BorrPd { get; set; }
        public decimal? BorrRaroc { get; set; }
        public decimal? ProposedExp { get; set; }
        public decimal? OtherIncome01 { get; set; }
        public decimal? OtherIncome02 { get; set; }
        public decimal? OtherIncome03 { get; set; }
        public decimal? OtherIncome04 { get; set; }
        public decimal? OtherIncome05 { get; set; }
        public decimal? ProcessingFee { get; set; }
        public decimal? UfceImpact { get; set; }
        public decimal? TotalCommitmentFee { get; set; }
        public decimal? TotalIncomeCapital { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IsProposalDeleted { get; set; }
    }
}
