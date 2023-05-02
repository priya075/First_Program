using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblProductAndPurpose0501bkp
    {
        public int PpId { get; set; }
        public string? PpText { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
