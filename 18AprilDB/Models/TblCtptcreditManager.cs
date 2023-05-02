using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptcreditManager
    {
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public int? CmId { get; set; }
        public bool? IsGcm { get; set; }
    }
}
