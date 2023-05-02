using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblCtptrmdetailsDeleted
    {
        public int Did { get; set; }
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public int RmId { get; set; }
        public bool IsGrm { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
