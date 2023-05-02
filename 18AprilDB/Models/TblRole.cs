using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRole
    {
        public int RId { get; set; }
        public int? CId { get; set; }
        public int MId { get; set; }
        public int? MWfId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? Status { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsRegionSpecific { get; set; }
        public bool? AllowManualDoa { get; set; }
    }
}
