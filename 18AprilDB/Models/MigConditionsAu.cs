using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class MigConditionsAu
    {
        public string? CustId { get; set; }
        public string? ConditionCategory { get; set; }
        public string? Condition { get; set; }
        public string? IsCommunicated { get; set; }
        public string? ComplianceStatus { get; set; }
        public string? PrePostDisbursement { get; set; }
        public string? MonthlyFrequency { get; set; }
        public string? Applicable { get; set; }
        public string? Status { get; set; }
        public string? DeferralApprovalDate { get; set; }
        public string? DefermentDueDate { get; set; }
        public string? DeferralType { get; set; }
    }
}
