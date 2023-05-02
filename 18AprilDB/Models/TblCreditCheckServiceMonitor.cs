using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCreditCheckServiceMonitor
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? TransactionId { get; set; }
        public string? ResponseRequestId { get; set; }
        public DateTime? RequestSentDateTime { get; set; }
        public string? PrimaryStatus { get; set; }
        public DateTime? PrimaryResponseDateTime { get; set; }
        public string? FinalStatus { get; set; }
        public DateTime? FinalResponseDateTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? EntityType { get; set; }
    }
}
