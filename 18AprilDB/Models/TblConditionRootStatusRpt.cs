using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblConditionRootStatusRpt
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? StdheaderText { get; set; }
        public string? ConditionCategory { get; set; }
        public string? UniqueId { get; set; }
        public string? Text { get; set; }
        public string? IsCommunicated { get; set; }
        public string? IsComplied { get; set; }
        public string? MonitoringFrequency { get; set; }
        public string? PrePost { get; set; }
        public string? CmMonitoringFrequency { get; set; }
        public string? CmPrePost { get; set; }
        public string? Applicability { get; set; }
        public DateTime? DefermentDueDate { get; set; }
        public string? DeferralType { get; set; }
    }
}
