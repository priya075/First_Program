using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptinternalRating
    {
        public int Id { get; set; }
        public string? CtptId { get; set; }
        public string? SsScore { get; set; }
        public int? RaId { get; set; }
        public int? CalculatedRtId { get; set; }
        public int? ProposedRtId { get; set; }
        public string? ReasonForOverride { get; set; }
        public decimal? ProbabilityDefault { get; set; }
        public DateTime? RatingDate { get; set; }
        public DateTime? RatingExpiryDate { get; set; }
        public string? AuditMethod { get; set; }
        public int? AuditYear { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Token { get; set; }
        public string? UserId { get; set; }
    }
}
