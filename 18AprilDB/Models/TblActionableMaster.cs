﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblActionableMaster
    {
        public int AcId { get; set; }
        public string AcText { get; set; } = null!;
        public string? AcDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
