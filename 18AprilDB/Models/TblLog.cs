using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblLog
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public DateTime? ActionTime { get; set; }
        public string? Status { get; set; }
    }
}
