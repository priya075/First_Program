using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRuleSetAccessLog
    {
        public int Id { get; set; }
        public string MachineName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime AccessTime { get; set; }
        public string Operation { get; set; } = null!;
        public string? RulesetName { get; set; }
    }
}
