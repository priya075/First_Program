using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblSblgbllimit
    {
        public int Id { get; set; }
        public string? SorG { get; set; }
        public string? CustomerFieldType { get; set; }
        public string? CustomerFieldValue { get; set; }
        public decimal? Limit { get; set; }
    }
}
