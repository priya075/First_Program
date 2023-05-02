using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblTaskTransferred
    {
        public int TftId { get; set; }
        public int CtptId { get; set; }
        public int MId { get; set; }
        public int? TaskTransferFrom { get; set; }
        public int? TaskTransferRole { get; set; }
        public int? TaskTransferTo { get; set; }
        public int? TaskTransferToRole { get; set; }
        public string? Description { get; set; }
    }
}
