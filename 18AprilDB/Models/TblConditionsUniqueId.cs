using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblConditionsUniqueId
    {
        public string CndValue { get; set; } = null!;
        public int CndId { get; set; }
        public int CtptId { get; set; }
    }
}
