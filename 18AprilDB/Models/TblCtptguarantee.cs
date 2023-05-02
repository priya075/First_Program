using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptguarantee
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? GuaranteeDesc { get; set; }
        public string? GuaranteeSrNo { get; set; }
        public string? FacSrNo { get; set; }
        public decimal? GuaranteeAmt { get; set; }
        public string? Currency { get; set; }
        public string? GuarantorBorrId { get; set; }
        public DateTime? GuarantorValidity { get; set; }
        public string? GuarantorRatingGrade { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
    }
}
