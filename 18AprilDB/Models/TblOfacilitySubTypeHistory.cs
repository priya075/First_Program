using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilitySubTypeHistory
    {
        public int Fstypid { get; set; }
        public string FacSubType { get; set; } = null!;
        public int? FstypT24pid { get; set; }
        public int? FstypFclsid { get; set; }
        public int? FacStage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
