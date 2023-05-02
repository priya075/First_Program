using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblReportFilter
    {
        public int RptfId { get; set; }
        public int ReId { get; set; }
        public string? FilterColumn { get; set; }
        public string? FilterType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
