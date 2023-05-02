using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblSubTemplate
    {
        public int TmpSubId { get; set; }
        public string? SubTemplate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? TmpId { get; set; }
    }
}
