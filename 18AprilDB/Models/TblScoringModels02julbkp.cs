﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblScoringModels02julbkp
    {
        public int Smmid { get; set; }
        public string? ModelName { get; set; }
        public string? ModelXml { get; set; }
        public int? Version { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
