using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigFacility
    {
        public string Token { get; set; } = null!;
        public string BorrId { get; set; } = null!;
        public decimal ModelId { get; set; }
        public string? FacilityId { get; set; }
        public decimal? ExtFacilityId { get; set; }
        public string? CbsLoanAc { get; set; }
        public string? ParentFacilityId { get; set; }
        public decimal? ExtParentFacilityId { get; set; }
        public decimal MstBankFacilityId { get; set; }
        public decimal? OsBalance { get; set; }
        public DateTime? OsRepDt { get; set; }
        public decimal? ProposedLimit { get; set; }
        public decimal? MstCurrencyId { get; set; }
        public DateTime? MaturityDt { get; set; }
        public decimal Tenor { get; set; }
        public decimal MstAssetclassId { get; set; }
        public decimal? IsConditionalFacility { get; set; }
        public decimal MstSectorId { get; set; }
        public decimal MstSubsectorId { get; set; }
        public decimal PercShare { get; set; }
        public decimal MstLendingtypeId { get; set; }
        public decimal IsSanctioned { get; set; }
        public decimal IsExisting { get; set; }
        public decimal ApproveRejectState { get; set; }
        public decimal? CommRate { get; set; }
        public decimal? LoanProcessingFee { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Datafeeddate { get; set; }
        public string PublisherCode { get; set; } = null!;
    }
}
