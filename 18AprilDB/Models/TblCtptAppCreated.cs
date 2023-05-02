using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptAppCreated
    {
        public int? CtptId { get; set; }
        public string? UniqueId { get; set; }
        public bool? IsAppCreate { get; set; }
        public bool? IsAppClosed { get; set; }
        public DateTime? CtptCreatedOn { get; set; }
    }
}
