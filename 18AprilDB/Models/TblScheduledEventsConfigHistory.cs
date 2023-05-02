using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblScheduledEventsConfigHistory
    {
        public int Id { get; set; }
        public int SecId { get; set; }
        public int CtptId { get; set; }
        public int ItemSubType { get; set; }
        public string SchItem { get; set; } = null!;
        public int? Frequency { get; set; }
        public bool IsSystemGenerated { get; set; }
        public int? CompletionDateOffSet { get; set; }
        public bool IsActive { get; set; }
        public int? UserAcknowledge { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
