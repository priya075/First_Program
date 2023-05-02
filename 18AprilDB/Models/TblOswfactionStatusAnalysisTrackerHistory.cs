using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusAnalysisTrackerHistory
    {
        public int Id { get; set; }
        public int WfstanlId { get; set; }
        public int WfstappId { get; set; }
        public string AnlId { get; set; } = null!;
        public int WfaId { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string? XmlAnalysis { get; set; }
        public int? AnalysisStructure { get; set; }
    }
}
