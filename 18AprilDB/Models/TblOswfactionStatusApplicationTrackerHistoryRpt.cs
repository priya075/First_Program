using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusApplicationTrackerHistoryRpt
    {
        public int WfstappId { get; set; }
        public string AppId { get; set; } = null!;
        public int CtptId { get; set; }
        public Guid AppGuid { get; set; }
        public int WfaId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int DeptId { get; set; }
        public string Uname { get; set; } = null!;
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public int? RId { get; set; }
        public bool? Committeeflag { get; set; }
        public int? CommitteeId { get; set; }
        public string? CommitteeName { get; set; }
        public int? Aptypid { get; set; }
        public bool? IsSuspended { get; set; }
        public int? MWfId { get; set; }
        public int? ParentMWfId { get; set; }
        public string? DeclinedAppId { get; set; }
    }
}
