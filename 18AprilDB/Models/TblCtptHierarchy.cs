using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptHierarchy
    {
        public int HrId { get; set; }
        public int? ParentCtptId { get; set; }
        public int? ChildCtptId { get; set; }
        public int? RootCtptId { get; set; }
        public int? CtptLevel { get; set; }
        public string? CtptPath { get; set; }
    }
}
