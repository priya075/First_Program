﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTrackingItemType
    {
        public int TraitmId { get; set; }
        public string TraitmText { get; set; } = null!;
        public string TraitmDesc { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
