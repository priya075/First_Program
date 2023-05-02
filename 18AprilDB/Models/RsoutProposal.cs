using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutProposal
    {
        public string? BorrId { get; set; }
        public string? Model { get; set; }
        public string? ProposalId { get; set; }
        public string? AssessmentType { get; set; }
        public string? BaseYear { get; set; }
        public DateTime? InitiationDate { get; set; }
        public string? InitiatedBy { get; set; }
        public string? IsProposalFinalized { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public string? FinalizedBy { get; set; }
        public string? FinalUserLevel { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
        public string? IndustryName { get; set; }
        public string? IsProposalDeleted { get; set; }
    }
}
