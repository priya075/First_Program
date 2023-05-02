using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblConfigurationsChangeLog
    {
        public int Id { get; set; }
        public string? ObjectName { get; set; }
        public string? ChangeType { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? ChangeDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LogCreatedOn { get; set; }
        public string? LogCreatedBy { get; set; }
        public DateTime? LogModifiedOn { get; set; }
        public string? LogModifiedBy { get; set; }
    }
}
