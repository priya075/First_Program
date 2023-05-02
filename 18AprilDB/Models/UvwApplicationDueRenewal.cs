using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UvwApplicationDueRenewal
    {
        public int? CtptId { get; set; }
        public string CounterPartyName { get; set; } = null!;
        public DateTime? SanctionDueDate { get; set; }
        public string? AppMngtEntity { get; set; }
        public string? PrimaryAliasId { get; set; }
        public string? SanctionId { get; set; }
    }
}
