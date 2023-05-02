using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOtenor
    {
        public int Tid { get; set; }
        public string? TenorDesc { get; set; }
        public int? Tenor { get; set; }
        public string? TenorUnit { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
