using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDoarule
    {
        public int Drid { get; set; }
        public string RuleNo { get; set; } = null!;
        public string RuleName { get; set; } = null!;
        public string RuleDescription { get; set; } = null!;
        public int MWfId { get; set; }
        public int? Polarity { get; set; }
    }
}
