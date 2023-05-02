using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilitySubType
    {
        public int Fstypid { get; set; }
        public string FacSubType { get; set; } = null!;
        public int? FstypT24pid { get; set; }
        public int? FstypFclsid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? PanelId { get; set; }
        public decimal? Ccf { get; set; }
        public string? PanelVirtualPath { get; set; }
        public int? MstSourceId { get; set; }
        public int? DefCondType { get; set; }
        public bool? AllowRootOnly { get; set; }
    }
}
