using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblWfconfigAttribute
    {
        public int WfpId { get; set; }
        public int? WfobjectId { get; set; }
        public string? TrackerTable { get; set; }
        public string? DraftTable { get; set; }
        public string? TrackerHistoryTable { get; set; }
        public string? InsertTrackerProc { get; set; }
        public string? DeleteDraftProc { get; set; }
        public string? MoveToHistoryProc { get; set; }
        public string? MainTrackerDeleteProc { get; set; }
        public string? SaveDraftProc { get; set; }
        public string? GetTasksProc { get; set; }
        public string? AcknowledgeTaskProc { get; set; }
        public string? GetTrackerProc { get; set; }
        public string? GetDraftProc { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
