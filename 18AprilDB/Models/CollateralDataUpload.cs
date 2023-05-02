using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class CollateralDataUpload
    {
        public string? Cif { get; set; }
        public string? CollateralSecurityId { get; set; }
        public string? CollateralRightId { get; set; }
        public string? CollateralCode { get; set; }
        public string? CollateralCodeDescription { get; set; }
        public string? CollateralSubCode { get; set; }
        public string? CollateralSubCodeDescription { get; set; }
        public string? CollateralCurrency { get; set; }
        public string? CollateralAmount { get; set; }
        public string? ColId { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
    }
}
