using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblEscalationDetail
    {
        public int? UserId { get; set; }
        public int RoleId { get; set; }
        public int TimeDiff { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Day { get; set; }
    }
}
