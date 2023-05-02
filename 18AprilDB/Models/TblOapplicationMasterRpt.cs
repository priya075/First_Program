using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationMasterRpt
    {
        public int Amid { get; set; }
        public string? Appid { get; set; }
        public int DptId { get; set; }
        public DateTime InitiationDate { get; set; }
        public int Aptypid { get; set; }
        public int BaseCurrency { get; set; }
        public int ApplicationRm { get; set; }
        public int? CtptId { get; set; }
        public string CtptUniqueId { get; set; } = null!;
        public string CounterPartyName { get; set; } = null!;
        public int GroupRm { get; set; }
        public int? Ctptindustry { get; set; }
        public int? EmployeeId { get; set; }
        public int? AppBranch { get; set; }
        public string? AppMngtEntity { get; set; }
        public string? Introduction { get; set; }
        public string? SanctionId { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? SanctionerId { get; set; }
        public DateTime? SanctionDueDate { get; set; }
        public bool? FacilityLetterIssued { get; set; }
        public int? MWfId { get; set; }
        public DateTime? IomSubmissionDate { get; set; }
        public string? IomPurpose { get; set; }
        public DateTime? ExtensionRequestDate { get; set; }
        public DateTime? SsNextFollowUpDate { get; set; }
        public string? ExistingRiskRating { get; set; }
        public string? ProposedRating { get; set; }
        public string? ApprovedRating { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? PurposeofCa { get; set; }
        public string? PdffileName { get; set; }
        public string? PdffilePath { get; set; }
    }
}
