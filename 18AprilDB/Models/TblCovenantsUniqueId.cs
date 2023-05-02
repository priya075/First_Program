using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCovenantsUniqueId
    {
        public string CovValue { get; set; } = null!;
        public int CovId { get; set; }
        public int CtptId { get; set; }
    }
}
