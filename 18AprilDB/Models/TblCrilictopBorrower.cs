using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCrilictopBorrower
    {
        public string? SrNo { get; set; }
        public string? BorrowerPan { get; set; }
        public string? BorrowerName { get; set; }
        public string? IndustryCode { get; set; }
        public string? IndustryDescription { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
