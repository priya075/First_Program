using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblDberrorLog
    {
        public int Id { get; set; }
        public string? SpName { get; set; }
        public string? ErrorMsg { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string? ErrorDetails { get; set; }
    }
}
