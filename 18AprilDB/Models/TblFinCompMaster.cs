using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinCompMaster
    {
        public int FinCompId { get; set; }
        public string? CompName { get; set; }
        public string? CompType { get; set; }
        public string? Description { get; set; }
        public string PrintName { get; set; } = null!;
        public int DisplaySeq { get; set; }
        public int? CompSubType { get; set; }
        public int? TmpId { get; set; }
    }
}
