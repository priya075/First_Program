using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptJointUtilization
    {
        public int CtptjuId { get; set; }
        public int? ParentCtptjuId { get; set; }
        public int? ChildCtptjuId { get; set; }
    }
}
