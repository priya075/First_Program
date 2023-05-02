using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRarocBaselEntityType
    {
        public int BaselEntityTypeId { get; set; }
        public string EntityType { get; set; } = null!;
        public decimal RiskWeight { get; set; }
        public bool? IsActive { get; set; }
    }
}
