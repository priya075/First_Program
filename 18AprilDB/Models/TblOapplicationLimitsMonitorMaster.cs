using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOapplicationLimitsMonitorMaster
    {
        public int AlmId { get; set; }
        public int WfstpafacId { get; set; }
        public string FacId { get; set; } = null!;
        public int CtptId { get; set; }
        public int? Amid { get; set; }
        public int WfstappId { get; set; }
        public int DeptId { get; set; }
        public string? XmlFac { get; set; }
        public int MWfId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
