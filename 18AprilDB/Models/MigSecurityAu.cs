using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigSecurityAu
    {
        public string? MigrationId { get; set; }
        public string? CollateralType { get; set; }
        public string? CollSubtype { get; set; }
        public string? OccupancyType { get; set; }
        public string? Cif { get; set; }
        public string? UcicId { get; set; }
        public string? CollateralValue { get; set; }
        public string? SharedWith { get; set; }
        public string? FltArea { get; set; }
        public string? CodAreaUnit { get; set; }
        public string? ColAddress { get; set; }
        public string? Pincode { get; set; }
        public string? CollateralDescription { get; set; }
        public string? ChargeSeniority { get; set; }
        public string? ChargeType { get; set; }
        public string? SecurityLevel { get; set; }
        public string? Specific { get; set; }
        public string? OurShare { get; set; }
        public string? NegativeArea { get; set; }
        public string? Takeover { get; set; }
        public string? OtherBuName { get; set; }
        public string? OtherBuCif { get; set; }
        public string? OtherBuAmount { get; set; }
    }
}
