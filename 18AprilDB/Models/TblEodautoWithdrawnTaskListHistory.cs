using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEodautoWithdrawnTaskListHistory
    {
        public int? Id { get; set; }
        public string? CustomerName { get; set; }
        public string? UniqueId { get; set; }
        public string? AppId { get; set; }
        public string? Purpose { get; set; }
        public string? BusinessSegment { get; set; }
        public string? Region { get; set; }
        public string? CreditCentre { get; set; }
        public string? SanctioningAuthority { get; set; }
        public int? RId { get; set; }
        public string? RoleName { get; set; }
        public string? CurrentUser { get; set; }
        public int? MWfId { get; set; }
        public string? WorkflowName { get; set; }
        public int? WfstappId { get; set; }
        public string? EmailId { get; set; }
        public string? CcemailId { get; set; }
        public bool? ReminderMailSentStatus { get; set; }
        public DateTime? ReminderSentDate { get; set; }
        public bool? MailSentStatus { get; set; }
        public DateTime? SentDate { get; set; }
        public bool? IsWithdrawn { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
