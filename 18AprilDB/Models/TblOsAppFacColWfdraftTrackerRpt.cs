using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblOsAppFacColWfdraftTrackerRpt
    {
        public int OsdrftId { get; set; }
        public int WfstId { get; set; }
        public int CtptId { get; set; }
        public string Ctptname { get; set; } = null!;
        public Guid AppGuid { get; set; }
        public string DraftType { get; set; } = null!;
        public int Uid { get; set; }
        public int RId { get; set; }
        public string UserName { get; set; } = null!;
        public int? DeptId { get; set; }
        public string Draftxml { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int? Aptypid { get; set; }
        public int? MWfId { get; set; }
    }
}
