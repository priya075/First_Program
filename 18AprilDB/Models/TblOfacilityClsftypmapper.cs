﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOfacilityClsftypmapper
    {
        public int Facmapid { get; set; }
        public int Fclsid { get; set; }
        public int Factypid { get; set; }
        public int Fstypid { get; set; }
        public int? Fstprodid { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? Facglobid { get; set; }
    }
}
