using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblMonitoringStatus
    {
        public int MsId { get; set; }
        public string MsText { get; set; } = null!;
        public string? MsDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
