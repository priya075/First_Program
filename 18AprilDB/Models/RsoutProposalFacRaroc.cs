using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutProposalFacRaroc
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? FacilityDesc { get; set; }
        public string? FacSrNo { get; set; }
        public decimal? ProposedLimit { get; set; }
        public decimal? ProposedInterestFee { get; set; }
        public decimal? FundingCost { get; set; }
        public decimal? EfficiencyRatio { get; set; }
        public decimal? CcfAvgUtilisation { get; set; }
        public decimal? CcfDrawnFac { get; set; }
        public decimal? CcfUndrawnExp { get; set; }
        public decimal? Pd { get; set; }
        public decimal? Lgd { get; set; }
        public decimal? El { get; set; }
        public decimal? CommitmentFee { get; set; }
        public decimal? IncomeFromCapital { get; set; }
        public decimal? OtherIncome { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? PreTaxnetincome { get; set; }
        public decimal? PostTaxnetincome { get; set; }
        public decimal? EconomicCapital { get; set; }
        public decimal? Raroc { get; set; }
        public decimal? HurdleRate { get; set; }
        public decimal? EconomicProfit { get; set; }
        public decimal? RealisedRaroc { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IsProposalDeleted { get; set; }
    }
}
