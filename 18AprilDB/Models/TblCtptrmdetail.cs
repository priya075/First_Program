using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptrmdetail
    {
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public int RmId { get; set; }
        public bool IsGrm { get; set; }
    }
}
