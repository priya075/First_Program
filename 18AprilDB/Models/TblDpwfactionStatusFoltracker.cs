using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDpwfactionStatusFoltracker
    {
        public int DocPrepId { get; set; }
        public string FolId { get; set; } = null!;
        public int CtptId { get; set; }
        public Guid FolGuid { get; set; }
        /// <summary>
        /// FK to tblWorkFlowActions
        /// </summary>
        public int WfaId { get; set; }
        public int? SubmitterRId { get; set; }
        /// <summary>
        /// Fk to tblUsers
        /// </summary>
        public int SubmitterUid { get; set; }
        /// <summary>
        /// FK to tblUsers
        /// </summary>
        public int? UserAcknowledgeUid { get; set; }
        public int? AcknowledgeUserRoleRid { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public int? Amid { get; set; }
        public string? SanctionId { get; set; }
        public string? Comment { get; set; }
        public int? WfstdocId { get; set; }
    }
}
