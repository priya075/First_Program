using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCompositeGroupConstitution
    {
        public int CgcId { get; set; }
        public int? GroupCtptId { get; set; }
        public string? GroupCtptName { get; set; }
        public int? MemberCtptId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
