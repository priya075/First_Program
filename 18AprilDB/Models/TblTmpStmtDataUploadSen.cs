using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTmpStmtDataUploadSen
    {
        public int TsdId { get; set; }
        public int? PrmId { get; set; }
        public string? Value { get; set; }
        public int? StmtId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public int? Amid { get; set; }
        public int? CtptId { get; set; }
    }
}
