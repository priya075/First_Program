using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblStatement
    {
        public int StmtId { get; set; }
        public int? ClientStmtId { get; set; }
        public int? CtptId { get; set; }
        public int? TmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
