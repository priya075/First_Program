using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblSmslogger
    {
        public int Id { get; set; }
        public string CtptId { get; set; } = null!;
        public string? EventAndPurpose { get; set; }
        public string? To { get; set; }
        public string? MessageType { get; set; }
        public string? MessageBody { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
