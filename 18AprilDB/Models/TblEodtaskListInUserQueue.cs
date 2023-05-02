using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEodtaskListInUserQueue
    {
        public int? Id { get; set; }
        public int? UId { get; set; }
        public string? UserName { get; set; }
        public string? CustomerName { get; set; }
        public string? CreditCentre { get; set; }
        public string? UniqueId { get; set; }
        public string? AppId { get; set; }
        public int? RId { get; set; }
        public string? RoleName { get; set; }
        public int? MWfId { get; set; }
        public string? WorkflowName { get; set; }
        public int? WfstappId { get; set; }
        public DateTime? TaskDateTime { get; set; }
        public string? EmailId { get; set; }
        public string? CcemailId { get; set; }
        public bool? MailSentStatus { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
