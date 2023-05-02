using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblConditionItemsStatusRpt
    {
        public int Id { get; set; }
        public int? SchId { get; set; }
        public string? SchItem { get; set; }
        public string? CndUniqueId { get; set; }
        public string? ItemUniqueId { get; set; }
        public string? ComplianceStatus { get; set; }
        public string? DeferralType { get; set; }
        public DateTime? DeferralsDueDate { get; set; }
        public DateTime? ItemGenerationDate { get; set; }
        public DateTime? ScheduleBeginningDate { get; set; }
        public int? CtptId { get; set; }
        public int? ItemSubType { get; set; }
        public int? IsSystemGenerated { get; set; }
        public int? Status { get; set; }
        public string? StText { get; set; }
        public int? Action { get; set; }
        public int? ActionByUser { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? XmlDetails { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? TraitmsDesc { get; set; }
        public string? SiXmlDetails { get; set; }
        public string? UniqueId { get; set; }
        public string? CndHeader { get; set; }
        public string? CndText { get; set; }
    }
}
