using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmsWfdraftTracker
    {
        public int DmdrftId { get; set; }
        public int? WfstdocId { get; set; }
        public int? DmDsId { get; set; }
        public string? DocId { get; set; }
        public Guid? DocGuid { get; set; }
        public int? MWfId { get; set; }
        public int? WfaId { get; set; }
        public int? RId { get; set; }
        public int? MId { get; set; }
        public int? UId { get; set; }
        public string? Uname { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? DeptId { get; set; }
        public string? XmlDraft { get; set; }
        public string? EntityType { get; set; }
        public string? EntityId { get; set; }
    }
}
