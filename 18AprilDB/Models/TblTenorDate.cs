using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTenorDate
    {
        public int? Tid { get; set; }
        public string? Tenor { get; set; }
        public DateTime? TenorDate { get; set; }
        public string? AssetType { get; set; }
        public int? Asid { get; set; }
    }
}
