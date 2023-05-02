using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptwfdraftTracker
    {
        public int CtptdrftId { get; set; }
        public int WfstId { get; set; }
        public int CtptId { get; set; }
        public Guid CtptGuid { get; set; }
        public string? Ctptname { get; set; }
        public int Uid { get; set; }
        public string? UserName { get; set; }
        public int? RId { get; set; }
        public string Draftxml { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int? MWfId { get; set; }
    }
}
