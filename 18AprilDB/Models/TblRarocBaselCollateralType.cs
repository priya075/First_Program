using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRarocBaselCollateralType
    {
        public int BaselCollateralId { get; set; }
        public string BaselCollateralName { get; set; } = null!;
        public decimal BaselCollateralHaircut { get; set; }
        public bool? IsActive { get; set; }
    }
}
