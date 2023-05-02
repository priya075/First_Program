using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDoAmatrix
    {
        public int DoAid { get; set; }
        public string? DoAtype { get; set; }
        public string? DoAname { get; set; }
        public string? Operator { get; set; }
        public decimal? NewDoA { get; set; }
        public decimal? OldDoA { get; set; }
        public int? MWfId { get; set; }
        public int? LRatingOrder { get; set; }
        public int? RRatingOrder { get; set; }
        public string? RdoAtype { get; set; }
        public string? RdoAname { get; set; }
        public string? A1doAtype { get; set; }
        public string? A1doAname { get; set; }
        public string? A2doAtype { get; set; }
        public string? A2doAname { get; set; }
        public int? SortOrder { get; set; }
    }
}
