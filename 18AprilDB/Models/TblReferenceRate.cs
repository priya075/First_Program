using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReferenceRate
    {
        public int RrtId { get; set; }
        public string? ReferenceRate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? MstSourceId { get; set; }
    }
}
