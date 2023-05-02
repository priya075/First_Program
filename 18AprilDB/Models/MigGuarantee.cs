using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigGuarantee
    {
        public string Token { get; set; } = null!;
        public string BorrId { get; set; } = null!;
        public decimal ModelId { get; set; }
        public string? GuaranteeId { get; set; }
        public decimal ExtGuaranteeId { get; set; }
        public string GuaranteeDetails { get; set; } = null!;
        public decimal MstGuarTypeId { get; set; }
        public decimal GuarantorBorrId { get; set; }
        public decimal GuaranteeValue { get; set; }
        public DateTime MaturityDate { get; set; }
        public DateTime? GuarInvocationDt { get; set; }
        public decimal RecoveryPerc { get; set; }
        public decimal MstGuarantorCatId { get; set; }
        public decimal MstGuarIntRatingId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Datafeeddate { get; set; }
        public string PublisherCode { get; set; } = null!;
    }
}
