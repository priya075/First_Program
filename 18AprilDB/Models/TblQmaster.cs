using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblQmaster
    {
        public decimal Qid { get; set; }
        public string? ObjectName { get; set; }
        public string? OperationType { get; set; }
        public DateTime? OperationTime { get; set; }
        public string? OperationUser { get; set; }
        public string? XmlIn { get; set; }
        public string? Status1 { get; set; }
        public string? Status2 { get; set; }
        public string? ErrorMsg { get; set; }
        public DateTime? ActionTime { get; set; }
    }
}
