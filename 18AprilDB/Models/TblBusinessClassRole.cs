﻿using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBusinessClassRole
    {
        public int BrId { get; set; }
        public int BcId { get; set; }
        public int RId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
