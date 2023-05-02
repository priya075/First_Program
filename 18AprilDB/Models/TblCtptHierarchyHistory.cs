using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptHierarchyHistory
    {
        public int? HrId { get; set; }
        public int? ParentCtptId { get; set; }
        public int? ChildCtptId { get; set; }
        public int? Stage { get; set; }
        public DateTime? BkpDate { get; set; }
    }
}
