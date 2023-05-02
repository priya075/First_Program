using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblExtBorrowerInfoHistory
    {
        public int Hid { get; set; }
        public int Mid { get; set; }
        public int CtptId { get; set; }
        public string Token { get; set; } = null!;
        public string BorrId { get; set; } = null!;
        public int ModelId { get; set; }
        public string? AppId { get; set; }
        public bool IsConsumed { get; set; }
        public bool IsPending { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public bool? IsDataSent { get; set; }
        public string? ServiceStatus { get; set; }
    }
}
