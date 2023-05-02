using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblFileMovement
    {
        public int SId { get; set; }
        public string? FileName { get; set; }
        public string? FileStatus { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? FileType { get; set; }
    }
}
