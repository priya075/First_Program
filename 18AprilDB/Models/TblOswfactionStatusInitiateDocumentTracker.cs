using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusInitiateDocumentTracker
    {
        public int WfstdocId { get; set; }
        public int WfstappId { get; set; }
        public string DocmntId { get; set; } = null!;
        public int? Amid { get; set; }
        public string? SanctionId { get; set; }
        public int CtptId { get; set; }
        public Guid DocGuid { get; set; }
        public int WfaId { get; set; }
        public int? MId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int DeptId { get; set; }
        public string Uname { get; set; } = null!;
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public bool? Committeeflag { get; set; }
        public int? CommitteeId { get; set; }
        public string? CommitteeName { get; set; }
        public int? Aptypid { get; set; }
        public int? MWfId { get; set; }
        public bool? IsSuspended { get; set; }
        public int? ParentMWfId { get; set; }
        public bool IssueOfFacilityLetter { get; set; }
        public string? Comments { get; set; }
    }
}
