using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDcwfactionStatusConstTrackerHistory
    {
        public int DocConstId { get; set; }
        public string ConstId { get; set; } = null!;
        public int CtptId { get; set; }
        public Guid ConstGuid { get; set; }
        public int WfaId { get; set; }
        public int? SubmitterRId { get; set; }
        public int SubmitterUid { get; set; }
        public int? UserAcknowledgeUid { get; set; }
        public int? AcknowledgeUserRoleRid { get; set; }
        public DateTime ActionDate { get; set; }
        public int? MWfId { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
    }
}
