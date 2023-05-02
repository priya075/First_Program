using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWfactionStatusAutoRenewalTracker
    {
        public int WfstarId { get; set; }
        public string ArId { get; set; } = null!;
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlDetails { get; set; }
        public int? MWfId { get; set; }
    }
}
