using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTreasuryTimeBucketsTenor
    {
        public int Bpid { get; set; }
        public int? Bid { get; set; }
        public int? Tid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
