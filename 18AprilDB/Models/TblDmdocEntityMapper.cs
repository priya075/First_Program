using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmdocEntityMapper
    {
        public int DmDemId { get; set; }
        public string? EntityType { get; set; }
        public int? EntityTypeId { get; set; }
        public int? DmDtypid { get; set; }
    }
}
