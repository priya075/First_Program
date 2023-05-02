using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRegion
    {
        public int RegnId { get; set; }
        public string? RegionName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
