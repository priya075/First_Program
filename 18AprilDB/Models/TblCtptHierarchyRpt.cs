using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptHierarchyRpt
    {
        public int HrId { get; set; }
        public int? ParentCtptId { get; set; }
        public int? ChildCtptId { get; set; }
    }
}
