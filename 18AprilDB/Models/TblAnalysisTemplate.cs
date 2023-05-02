using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAnalysisTemplate
    {
        public int TmpId { get; set; }
        public string TmpKey { get; set; } = null!;
        public string Template { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? MWfId { get; set; }
        public string? TmpType { get; set; }
    }
}
