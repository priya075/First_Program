using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptratingHistory
    {
        public int CthRtId { get; set; }
        public int CtRtId { get; set; }
        public string? CtptId { get; set; }
        public int? RaId { get; set; }
        public int? RtId { get; set; }
        public string? RatingAgency { get; set; }
        public string? RatingScale { get; set; }
        public string? Rating { get; set; }
        public DateTime? RatingDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Outlook { get; set; }
        public decimal? Amount { get; set; }
        public string? Instrument { get; set; }
    }
}
