using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDocumentationReportHistoryRpt
    {
        public int? WfstdocId { get; set; }
        public string? DocmntId { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public int? MWfId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? WfstappId { get; set; }
        public int? Amid { get; set; }
        public string? SanctionId { get; set; }
        public int? CtptId { get; set; }
        public int? WfaId { get; set; }
    }
}
