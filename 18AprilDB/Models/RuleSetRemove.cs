using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RuleSetRemove
    {
        public string Name { get; set; } = null!;
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string RuleSet { get; set; } = null!;
        public short? Status { get; set; }
        public string? AssemblyPath { get; set; }
        public string? ActivityName { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
