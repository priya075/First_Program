using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmwfactionStatusTracker
    {
        public int WfstdocId { get; set; }
        public int? DmDsId { get; set; }
        public int? EnvelopId { get; set; }
        public string? DocId { get; set; }
        public Guid? DocGuid { get; set; }
        public int? MWfId { get; set; }
        public int? WfaId { get; set; }
        public int? RId { get; set; }
        public int? MId { get; set; }
        public int? ActionSubmitBy { get; set; }
        public string? Uname { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? EnvelopStatus { get; set; }
        public int? DeptId { get; set; }
        public int? WaiverPeriod { get; set; }
        public int? ReleaseReturnPeriod { get; set; }
        public string? EntityType { get; set; }
        public string? EntityId { get; set; }
        public string? XmlIn { get; set; }
        public string? XmlOut { get; set; }
    }
}
