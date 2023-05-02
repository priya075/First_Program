using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblChkListNsfabove1Cr
    {
        public string? Bank { get; set; }
        public string? Branch { get; set; }
        public string? Quarter { get; set; }
        public string? BorrowerName { get; set; }
        public string? DirectorNameAndDin { get; set; }
        public string? OutStandingAmount { get; set; }
        public string? DateOfDissemination { get; set; }
        public DateTime? DataFeedDate { get; set; }
    }
}
