using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMcaorderSectionStatus
    {
        public int Id { get; set; }
        public string OrderReference { get; set; } = null!;
        public string? Section { get; set; }
        public string SectionFetchedStatus { get; set; } = null!;
        public string? Response { get; set; }
        public DateTime? FetchedDateTime { get; set; }
    }
}
