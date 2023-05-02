using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblRiskNoteGenerationQueueMixupHistory
    {
        public int Hid { get; set; }
        public int Id { get; set; }
        public int? WfstappId { get; set; }
        public string? Purpose { get; set; }
        public int? ExecutionStatus { get; set; }
        public int? Priority { get; set; }
        public int? AckM { get; set; }
        public string? RequestFrom { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
