using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmdocumentMaster
    {
        public int DmId { get; set; }
        public int? DmDtypid { get; set; }
        public string? DocId { get; set; }
        public string? EntityType { get; set; }
        public string? FacilityId { get; set; }
        public string? CollateralId { get; set; }
        public string? CounterPartyId { get; set; }
        public string? SanctionId { get; set; }
        public DateTime? SanctionIssueDate { get; set; }
        public int? MWfId { get; set; }
        public string? DocumentStatus { get; set; }
        public int? SubmittedBy { get; set; }
        public int? ReleasedBy { get; set; }
        public int? BusinessUnit { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? LodgementId { get; set; }
        public DateTime? LodgementDate { get; set; }
        public int WaiverPeriod { get; set; }
        public int ReleaseReturnPeriod { get; set; }
        public bool? DocumentationCompletion { get; set; }
        public DateTime? DefermentDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Dmslink { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DocumentExpiryDate { get; set; }
    }
}
