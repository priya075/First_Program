using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFileMovementHistory
    {
        public string? SId { get; set; }
        public string? FileName { get; set; }
        public string? FileStatus { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? FileType { get; set; }
    }
}
