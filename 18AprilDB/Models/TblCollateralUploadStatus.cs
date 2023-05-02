using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCollateralUploadStatus
    {
        public int SId { get; set; }
        public string? Record { get; set; }
        public string? FileStatus { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? FileType { get; set; }
    }
}
