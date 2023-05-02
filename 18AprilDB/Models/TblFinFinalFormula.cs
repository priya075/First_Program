using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinFinalFormula
    {
        public int? Sno { get; set; }
        public string? Formula { get; set; }
        public int? Seq { get; set; }
        public int? TmpId { get; set; }
        public bool? IsCalculationRequired { get; set; }
    }
}
