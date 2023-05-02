using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWfactionStatusTrackerForOutOfOffice
    {
        public int WfstId { get; set; }
        public int CtptId { get; set; }
        public Guid? CtptGuid { get; set; }
        public int? WfaId { get; set; }
        public string? UniqueId { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public int RId { get; set; }
        public int? MId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? Xmlin { get; set; }
        public string? Xmlout { get; set; }
    }
}
