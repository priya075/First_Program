using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTemplateServiceMonitor
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceId { get; set; }
        public int? RestartFlag { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? RestartAttemptOn { get; set; }
        public string? Status { get; set; }
        public DateTime? StatusOn { get; set; }
    }
}
