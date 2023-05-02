using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class T24prodMaster
    {
        public int Tmid { get; set; }
        public int? T24pid { get; set; }
        public string T24prodName { get; set; } = null!;
        public bool? IsRevolving { get; set; }
        public decimal CcfperYear { get; set; }
        public int? Clsfid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ProductPurpose { get; set; }
    }
}
