using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBankingStatementAnalysis
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? AppId { get; set; }
        public string? RequestId { get; set; }
        public string? DocId { get; set; }
        public string? Status { get; set; }
        public string? StatusDescription { get; set; }
        public string? FileName { get; set; }
        public string? FileData { get; set; }
        public string? Analysis { get; set; }
        public string? ServiceStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? TotalAttempt { get; set; }
        public string? AccountNo { get; set; }
        public string? IfscCode { get; set; }
        public string? PeriodStart { get; set; }
        public string? PeriodEnd { get; set; }
        public string? Password { get; set; }
        public string? BankName { get; set; }
        public string? AccHolderName { get; set; }
        public string? FileType { get; set; }
        public string? RelatedAccounts { get; set; }
        public string? RelatedPartyKeywords { get; set; }
        public int? AccountType { get; set; }
    }
}
