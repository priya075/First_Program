using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFinFormula
    {
        public decimal FinCompId { get; set; }
        public string TemplateId { get; set; } = null!;
        public decimal? SeqNo { get; set; }
        public string Formula { get; set; } = null!;
        public DateTime? EffectiveFrom { get; set; }
        public string? LastFormula { get; set; }
        public string? LastUpdateValue { get; set; }
        public int? TmpId { get; set; }
        public bool? IsCalculationRequired { get; set; }
    }
}
