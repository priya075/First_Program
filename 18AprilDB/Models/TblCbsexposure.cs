using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCbsexposure
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerFullName { get; set; }
        public string? ModuleCode { get; set; }
        public string? AccountId { get; set; }
        public string? ProductName { get; set; }
        public string? CustomerRelationship { get; set; }
        public string? CurrentStatus { get; set; }
        public string? BranchName { get; set; }
        public string? ProdCode { get; set; }
        public string? LoanTerm { get; set; }
        public string? SanctionedAmount { get; set; }
        public string? DisbAmount { get; set; }
        public string? InterestRate { get; set; }
        public string? NextInstallmentDue { get; set; }
        public string? PrincipalBalance { get; set; }
        public string? AvailableBalance { get; set; }
        public string? TotalOutstandings { get; set; }
        public string? TotalNoOfInstallmentsReceived { get; set; }
        public string? InstallmentsOverDue { get; set; }
        public string? InstallmentsReceivedAdv { get; set; }
        public string? ProductCategory { get; set; }
        public string? InstallamentFrequency { get; set; }
        public string? LimitAmt { get; set; }
        public string? LineStartDate { get; set; }
        public string? LineEndDate { get; set; }
        public string? LineId { get; set; }
        public string? MainlineId { get; set; }
        public string? Mainlinedesc { get; set; }
        public string? DlodFlag { get; set; }
        public string? CredProId { get; set; }
        public string? BusinessUnit { get; set; }
        public string? ServiceSource { get; set; }
        public DateTime LoadDate { get; set; }
    }
}
