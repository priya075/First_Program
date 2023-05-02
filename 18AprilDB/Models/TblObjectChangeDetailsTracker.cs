using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblObjectChangeDetailsTracker
    {
        public int OcdId { get; set; }
        public int WfstappId { get; set; }
        public int CtptId { get; set; }
        public string ObjChangeDetails { get; set; } = null!;
        public string XmlDetails { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public DateTime ActionDate { get; set; }
    }
}
