using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblScheduledItemsTracker
    {
        public int WfsttrackId { get; set; }
        public string TrackId { get; set; } = null!;
        public int CtptId { get; set; }
        public int TrkitemId { get; set; }
        public int TrkitemSubTypeId { get; set; }
        public int WfaId { get; set; }
        public int RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public int UserAcknowledge { get; set; }
        public int AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
        public int MWfId { get; set; }
        public int? ObjectId { get; set; }
    }
}
