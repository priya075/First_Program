using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigPropSec
    {
        public string Token { get; set; } = null!;
        public string BorrId { get; set; } = null!;
        public decimal ModelId { get; set; }
        public string? SecurityId { get; set; }
        public string? FacilityId { get; set; }
        public decimal ExtSecurityId { get; set; }
        public decimal ExtFacilityId { get; set; }
        public decimal ActualSecValue { get; set; }
        public decimal IsGuarantee { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Datafeeddate { get; set; }
        public string PublisherCode { get; set; } = null!;
    }
}
