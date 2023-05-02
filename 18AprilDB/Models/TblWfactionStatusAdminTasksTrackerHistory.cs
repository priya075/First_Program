using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWfactionStatusAdminTasksTrackerHistory
    {
        public int Id { get; set; }
        public int WfstatId { get; set; }
        public string ChangeId { get; set; } = null!;
        public int LinkId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlDetails { get; set; }
        public int? MWfId { get; set; }
    }
}
