using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilityGlobal
    {
        public int Facglobid { get; set; }
        public string FacilityGlobal { get; set; } = null!;
        public int? FacglobT24pid { get; set; }
        public int? FacglobFclsid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
