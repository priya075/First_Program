﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReportAccess
    {
        public int RaId { get; set; }
        public int UId { get; set; }
        public int? MId { get; set; }
        public int? MWfId { get; set; }
        public int? ReId { get; set; }
        public int? RId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
