﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAnalysisTabMaster
    {
        public int TabId { get; set; }
        public string? TabName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
