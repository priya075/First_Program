using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmsslreferenceNumber
    {
        public int Id { get; set; }
        public int CtptId { get; set; }
        public string? CurrentReferenceNumber { get; set; }
        public string? LastReferenceNumber { get; set; }
        public string? CurrentReferenceNumberM { get; set; }
        public string? LastReferenceNumberM { get; set; }
        public int? DmDtypid { get; set; }
        public int? Active { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
