using System;
using System.Collections.Generic;

namespace _18AprilDB.Models
{
    public partial class Hash
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Field { get; set; } = null!;
        public string? Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
