using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblListingInfo
    {
        public int LiId { get; set; }
        public string? CtptId { get; set; }
        public int? ExId { get; set; }
        public string? Ticker { get; set; }
        public DateTime? ListingDate { get; set; }
        public string? FaceValue { get; set; }
        public int? CrId { get; set; }
        public string? Isin { get; set; }
    }
}
