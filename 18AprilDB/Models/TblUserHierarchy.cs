using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblUserHierarchy
    {
        public int EhrId { get; set; }
        public string? ParentEId { get; set; }
        public string? ChildEId { get; set; }
        public string? RootEId { get; set; }
        public int? ELevel { get; set; }
        public string? EPath { get; set; }
    }
}
