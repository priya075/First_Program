using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class UserAppAuthMig
    {
        public string? Userid { get; set; }
        public int? RegnId { get; set; }
        public int? ProgId { get; set; }
        public int? MWfId { get; set; }
        public decimal? ApprovingAmount { get; set; }
    }
}
