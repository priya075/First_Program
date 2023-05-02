using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwFacilitySubTypeClassification
    {
        public int Fstypid { get; set; }
        public string FacSubType { get; set; } = null!;
        public int? FstypFclsid { get; set; }
        public int? PanelId { get; set; }
        public decimal? Ccf { get; set; }
        public string? PanelVirtualPath { get; set; }
        public int? MstSourceId { get; set; }
        public int? DefCondType { get; set; }
        public bool? AllowRootOnly { get; set; }
        public string Classification { get; set; } = null!;
        public bool? IsDirect { get; set; }
    }
}
