using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblServiceCallLog
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public string? RequestObject { get; set; }
    }
}
