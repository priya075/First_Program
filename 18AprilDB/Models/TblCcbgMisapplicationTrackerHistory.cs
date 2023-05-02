using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCcbgMisapplicationTrackerHistory
    {
        public int WfstappId { get; set; }
        public int CtptId { get; set; }
        public string AppId { get; set; } = null!;
        public int? UnitHead { get; set; }
        public string UnitHeadName { get; set; } = null!;
        public int? ZonalHead { get; set; }
        public string ZonalHeadName { get; set; } = null!;
        public string? PurposeofCa { get; set; }
        public DateTime? ApplicationStartDate { get; set; }
        public string? Zone { get; set; }
        public DateTime? CreditFirstDate { get; set; }
        public int? BusinessTat { get; set; }
        public int? CreditTat { get; set; }
        public int? CommitteeTat { get; set; }
        public int? FinalizationTat { get; set; }
        public int? TotalTat { get; set; }
        public int? HolidayOrWeekends { get; set; }
        public int? CustTrackIdout { get; set; }
        public string? CreditAnalysts { get; set; }
        public int? ReturnedToBusinessCount { get; set; }
        public string? StatusOfApplication { get; set; }
        public string? ScoreGrade { get; set; }
        public string? ProposedRating { get; set; }
        public string? ManualOverride { get; set; }
        public string? OverRideComments { get; set; }
        public decimal? Indebtnessamount { get; set; }
        public DateTime? ApplicationClosedDate { get; set; }
        public string? ApprovingAuthority { get; set; }
    }
}
