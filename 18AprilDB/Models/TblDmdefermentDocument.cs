using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmdefermentDocument
    {
        public int DmdId { get; set; }
        public int CtptId { get; set; }
        public int Amid { get; set; }
        public int WfstappId { get; set; }
        public string SlId { get; set; } = null!;
        public string AppId { get; set; } = null!;
        public string? SanctionId { get; set; }
        public int? DeptId { get; set; }
        public string? DocId { get; set; }
        public int? DmDtypid { get; set; }
        public string? EntityId { get; set; }
        public string? EntityType { get; set; }
        public string? Docgentype { get; set; }
        public string XmlDetails { get; set; } = null!;
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
