using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilityType
    {
        public int Factypid { get; set; }
        public string FacilityType { get; set; } = null!;
        public int? FactypT24pid { get; set; }
        public int? FactypFclsid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? AllowRootOnly { get; set; }
    }
}
