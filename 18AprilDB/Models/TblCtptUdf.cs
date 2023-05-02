using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptUdf
    {
        public int UdfId { get; set; }
        public string CtptId { get; set; } = null!;
        public string? FieldName { get; set; }
        public string? FieldDataType { get; set; }
        public string? Format { get; set; }
    }
}
