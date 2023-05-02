using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDpwfactionStatusFoltrackerHistory
    {
        public int DocPrepId { get; set; }
        public string FolId { get; set; } = null!;
        public int CtptId { get; set; }
        public Guid FolGuid { get; set; }
        public int WfaId { get; set; }
        public int? SubmitterRId { get; set; }
        public int SubmitterUid { get; set; }
        public int? UserAcknowledgeUid { get; set; }
        public int? AcknowledgeUserRoleRid { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public int? Amid { get; set; }
        public string? SanctionId { get; set; }
        public int? WfstdocId { get; set; }
    }
}
