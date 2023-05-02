using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwCollateralTypeSubtype
    {
        public int? Coltypid { get; set; }
        public string? CollateralCode { get; set; }
        public string? CollateralType { get; set; }
        public string? Nature { get; set; }
        public int? Cstypid { get; set; }
        public string? CollateralSubCode { get; set; }
        public string? ColSubType { get; set; }
        public decimal? RealizableValue { get; set; }
        public int? MstSourceId { get; set; }
        public int Colmapid { get; set; }
    }
}
