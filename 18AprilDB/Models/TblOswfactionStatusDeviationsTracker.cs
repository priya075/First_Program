using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOswfactionStatusDeviationsTracker
    {
        public int WfstdvnId { get; set; }
        public int WfstappId { get; set; }
        public string DvnId { get; set; } = null!;
        public int WfaId { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
        public int ActionSubmitBy { get; set; }
        public string Uname { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public string? XmlDeviations { get; set; }
    }
}
