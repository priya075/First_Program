using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmwfactionStatusFacilityPostApprovalTrackerHistory
    {
        public int Id { get; set; }
        public int WfstpafacId { get; set; }
        public string FacId { get; set; } = null!;
        public int CtptId { get; set; }
        public int? Amid { get; set; }
        public int WfstappId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int DeptId { get; set; }
        public int RegnId { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlFac { get; set; }
        public int MWfId { get; set; }
    }
}
