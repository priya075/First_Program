using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwFacilityClassificationMi
    {
        public int Fstypid { get; set; }
        public string FacSubType { get; set; } = null!;
        public int? FstypFclsid { get; set; }
        public string Classification { get; set; } = null!;
        public string ClassificationMis { get; set; } = null!;
    }
}
