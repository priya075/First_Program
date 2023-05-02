using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class RsoutBorrBasicInfo
    {
        public string BorrId { get; set; } = null!;
        public string BorrName { get; set; } = null!;
        public string? Pan { get; set; }
        public string? Userid { get; set; }
        public DateTime? Datafeeddate { get; set; }
        public string? PublisherCode { get; set; }
    }
}
