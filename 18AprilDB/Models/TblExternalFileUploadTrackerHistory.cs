using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExternalFileUploadTrackerHistory
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string FileName { get; set; } = null!;
        public string? FilePath { get; set; }
        public string FileMasterObject { get; set; } = null!;
        public string MasterObjectId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? ExternalDocRef { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UploadOn { get; set; }
    }
}
