using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExternalFileUploadTrackerAutoUploadLog
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public int? AttemptCount { get; set; }
        public string? AttemptStatus { get; set; }
        public DateTime? AttemptDateTime { get; set; }
    }
}
