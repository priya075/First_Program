using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrackingItemSubType
    {
        public int TraitmsId { get; set; }
        public string TraitmsText { get; set; } = null!;
        public string TraitmsDesc { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
