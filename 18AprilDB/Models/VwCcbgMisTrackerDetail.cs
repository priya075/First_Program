using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class VwCcbgMisTrackerDetail
    {
        public string AppId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string GroupName { get; set; } = null!;
        public string? Pan { get; set; }
        public string? BusinessUnit { get; set; }
        public string? Zone { get; set; }
        public string? RmName { get; set; }
        public string ZhName { get; set; } = null!;
        public string BhName { get; set; } = null!;
        public string? CreditAnalystName { get; set; }
        public string? Status { get; set; }
        public string? PurposeOfCam { get; set; }
        public string? DateOfLoginToCredit { get; set; }
        public string? DateOfFinalSanction { get; set; }
        public int? NoOfTimesReturnedToBusiness { get; set; }
        public int? BusinessTat { get; set; }
        public int? CreditTat { get; set; }
        public int? CommitteeTat { get; set; }
        public int? FinalizationTat { get; set; }
        public int? TotalTat { get; set; }
        public int? HolidayOrWeekends { get; set; }
        public string ApprovingCommittee { get; set; } = null!;
        public string? ManualOverride { get; set; }
        public string? OverrideComments { get; set; }
        public decimal? SanctionedAmount { get; set; }
        public decimal? ExposureAmount { get; set; }
        public string? InternalApprovedRating { get; set; }
        public string? Industry { get; set; }
        public DateTime? ApplicationStartDate { get; set; }
    }
}
