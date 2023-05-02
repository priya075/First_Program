using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmwfactionStatusDoclodgementTrackerHistory
    {
        public int Id { get; set; }
        public int WfstdocId { get; set; }
        public int DocrefId { get; set; }
        public string DocId { get; set; } = null!;
        public int DmDtypid { get; set; }
        public int CtptId { get; set; }
        public int? Amid { get; set; }
        public int WfstappId { get; set; }
        public string? AppId { get; set; }
        public string? SanctionId { get; set; }
        public string? SlId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int DeptId { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlDoc { get; set; }
        public int MWfId { get; set; }
        public DateTime? AcknowledgeDate { get; set; }
    }
}
