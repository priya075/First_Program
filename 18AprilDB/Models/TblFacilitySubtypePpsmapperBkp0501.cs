﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFacilitySubtypePpsmapperBkp0501
    {
        public int Fstpmid { get; set; }
        public int Facid { get; set; }
        public int PpId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
