using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class TblBlockedIpDetail
    {
        public int Bipid { get; set; }
        public string? IpAddress { get; set; }
        public string? UserId { get; set; }
        public bool? IsBlocked { get; set; }
        public DateTime? BlockedDate { get; set; }
        public string? UnBlockedBy { get; set; }
        public DateTime? UnBlockedDate { get; set; }
    }
}
