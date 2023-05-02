using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigSecurity
    {
        public string Token { get; set; } = null!;
        public string BorrId { get; set; } = null!;
        public decimal ModelId { get; set; }
        public string? SecurityId { get; set; }
        public decimal? ExtSecurityId { get; set; }
        public decimal MstBankSecId { get; set; }
        public decimal MstSecTypeId { get; set; }
        public decimal MstChargetypeId { get; set; }
        public decimal MstSeniorityId { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public decimal? IsOrigDoc { get; set; }
        public decimal? IsLegalOpinion { get; set; }
        public decimal? MstBranchId { get; set; }
        public decimal MstCurrencyId { get; set; }
        public decimal ActualSecValue { get; set; }
        public DateTime ValuationDt { get; set; }
        public decimal RecoveryPerc { get; set; }
        public decimal NumLenders { get; set; }
        public decimal MstSecMktblyId { get; set; }
        public decimal MstDocQltyId { get; set; }
        public string SecDetails { get; set; } = null!;
        public string? InsPolicyNo { get; set; }
        public decimal? InsAmount { get; set; }
        public string? InsCompanyName { get; set; }
        public DateTime? InsExpiryDt { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Datafeeddate { get; set; }
        public string PublisherCode { get; set; } = null!;
    }
}
