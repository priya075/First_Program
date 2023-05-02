using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCounterpartyJvinfo
    {
        public int JvId { get; set; }
        public string CtptId { get; set; } = null!;
        public int CtJvId { get; set; }
        public string? CtJvName { get; set; }
        public decimal Percentage { get; set; }
    }
}
