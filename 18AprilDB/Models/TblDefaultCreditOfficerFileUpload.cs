using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDefaultCreditOfficerFileUpload
    {
        public int FileId { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string? ValidateStatus { get; set; }
        public string? ValidateStatusMsg { get; set; }
        public int? UId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
