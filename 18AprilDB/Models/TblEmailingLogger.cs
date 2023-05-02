using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEmailingLogger
    {
        public int ElId { get; set; }
        public string ToUsers { get; set; } = null!;
        public string? Ccusers { get; set; }
        public string? Bccusers { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
