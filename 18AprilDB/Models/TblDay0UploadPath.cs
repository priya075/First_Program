using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDay0UploadPath
    {
        public int PathId { get; set; }
        public string KeyValue { get; set; } = null!;
        public string? UploadPath { get; set; }
    }
}
