using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWfactionStatusProjectTrackerHistory
    {
        public int WfstcphId { get; set; }
        public int WfstcpId { get; set; }
        public int CtptId { get; set; }
        public string ProjectId { get; set; } = null!;
        public int? WfaId { get; set; }
        public int RId { get; set; }
        public int? MId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public string? ObjectName { get; set; }
        public int? MWfId { get; set; }
        public string? ParentProjectId { get; set; }
    }
}
