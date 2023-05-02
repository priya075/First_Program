using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRarocBaselFacilityType
    {
        public int BaselFacilityId { get; set; }
        public string BaselFacilityName { get; set; } = null!;
        public decimal BaselFacilityCcf { get; set; }
        public bool? ManualCcf { get; set; }
        public bool? IsActive { get; set; }
    }
}
