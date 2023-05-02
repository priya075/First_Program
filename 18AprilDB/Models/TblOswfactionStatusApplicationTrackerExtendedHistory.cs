using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusApplicationTrackerExtendedHistory
    {
        public int WfstappId { get; set; }
        public string AppId { get; set; } = null!;
        public int CtptId { get; set; }
        public Guid AppGuid { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlOut { get; set; }
    }
}
