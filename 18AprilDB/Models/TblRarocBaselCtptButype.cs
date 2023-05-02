using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRarocBaselCtptButype
    {
        public int BaselCtptButypeId { get; set; }
        public string Butype { get; set; } = null!;
        public decimal CtptBuopCostToLimitRatio { get; set; }
    }
}
