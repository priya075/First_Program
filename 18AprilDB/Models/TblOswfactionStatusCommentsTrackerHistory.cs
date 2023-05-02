using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusCommentsTrackerHistory
    {
        public int Id { get; set; }
        public int WfstcmtId { get; set; }
        public int WfstappId { get; set; }
        public string CmtId { get; set; } = null!;
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public DateTime ActionDate { get; set; }
        public string Xml { get; set; } = null!;
        public int? MWfId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
