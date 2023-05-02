using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrxnProductAssetType
    {
        public int Id { get; set; }
        public string? TrxnProductType { get; set; }
        public int? Asid { get; set; }
        public string? ProductDescription { get; set; }
        public string? SchmType { get; set; }
        public int? Polarity { get; set; }
    }
}
