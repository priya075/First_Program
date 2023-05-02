using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblLocationMaster
    {
        public int LocId { get; set; }
        public string? LocationId { get; set; }
        public string? LocationCode { get; set; }
        public string? LocationName { get; set; }
    }
}
