using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptuploadedFile
    {
        public int CtUfId { get; set; }
        public string? CtptId { get; set; }
        public string? FileName { get; set; }
        public string? BrowserUrl { get; set; }
    }
}
