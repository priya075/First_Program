using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDmdocumentAttachmentLevelLinkingMaster
    {
        public int Id { get; set; }
        public int? CtptId { get; set; }
        public string? SlId { get; set; }
        public string? DocId { get; set; }
        public int? DmDtypid { get; set; }
        public string? EntityId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public int? Amid { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
