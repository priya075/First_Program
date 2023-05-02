using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptchargeDtl
    {
        public string? BorrId { get; set; }
        public string? ProposalId { get; set; }
        public string? FacSrNo { get; set; }
        public string? SecSrNo { get; set; }
        public string? BankDesc { get; set; }
        public string? ChargeDesc { get; set; }
        public decimal? SecurityAmt { get; set; }
        public string? UserId { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
    }
}
