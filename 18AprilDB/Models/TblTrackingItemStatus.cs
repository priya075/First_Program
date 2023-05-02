using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrackingItemStatus
    {
        public int StId { get; set; }
        public string StSysname { get; set; } = null!;
        public string StText { get; set; } = null!;
        public string StTextDesc { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
