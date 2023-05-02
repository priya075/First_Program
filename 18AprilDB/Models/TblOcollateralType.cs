using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOcollateralType
    {
        public int Coltypid { get; set; }
        public string? CollateralCode { get; set; }
        public string CollateralType { get; set; } = null!;
        public int? NewCollateralSerial { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Nature { get; set; }
    }
}
