using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblScheduledItem
    {
        public int SchId { get; set; }
        public int CtptId { get; set; }
        public int ItemSubType { get; set; }
        public bool IsSystemGenerated { get; set; }
        public int Status { get; set; }
        public int? Action { get; set; }
        public int? ActionByUser { get; set; }
        public DateTime? ActionDate { get; set; }
        public string XmlDetails { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ColId { get; set; }
    }
}
