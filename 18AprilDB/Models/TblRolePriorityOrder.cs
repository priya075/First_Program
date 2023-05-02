using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRolePriorityOrder
    {
        public int PrId { get; set; }
        public string? RoleName { get; set; }
        public int? PriorityOrder { get; set; }
        public string? Lvl { get; set; }
    }
}
