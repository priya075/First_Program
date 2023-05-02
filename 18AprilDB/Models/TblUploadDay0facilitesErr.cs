using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUploadDay0facilitesErr
    {
        public int ErrId { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public DateTime? Date { get; set; }
        public string? UploadType { get; set; }
    }
}
