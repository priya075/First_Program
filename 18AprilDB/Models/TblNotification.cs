using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblNotification
    {
        public int Id { get; set; }
        public string Details { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
