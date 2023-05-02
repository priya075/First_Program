using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmwfactionStatusLsmtrackerHistory
    {
        public int Id { get; set; }
        public int WfstlsmId { get; set; }
        public string LsmId { get; set; } = null!;
        public int CtptId { get; set; }
        public int WfaId { get; set; }
        public int? RId { get; set; }
        public int ActionSubmitBy { get; set; }
        public int? UserAcknowledge { get; set; }
        public int? AcknowledgeUserRole { get; set; }
        public DateTime ActionDate { get; set; }
        public string? XmlDetails { get; set; }
        public int MWfId { get; set; }
        public DateTime? AcknowledgeDate { get; set; }
    }
}
