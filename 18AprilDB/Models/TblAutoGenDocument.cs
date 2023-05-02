using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblAutoGenDocument
    {
        public int Id { get; set; }
        public string? DocumentName { get; set; }
        public string? BusinessGroup { get; set; }
        public string? ProposalType { get; set; }
        public string? ProgramType { get; set; }
        public string? FacilityType { get; set; }
        public string? SecurityType { get; set; }
        public string? Seniority { get; set; }
        public string? Consitution { get; set; }
        public string? BalanceTransferTakeOver { get; set; }
        public string? Lessee { get; set; }
        public string? ExtenstionCreation { get; set; }
        public string? ExecutorStatus { get; set; }
        public string? SystemGenerated { get; set; }
        public string? DocumentTypes { get; set; }
        public string? DocumentRemarks { get; set; }
        public string? FormatStatus { get; set; }
        public string? DocumentTemplateName { get; set; }
    }
}
